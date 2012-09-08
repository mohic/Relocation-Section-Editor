using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace Relocation_Section_Editor
{
    public class Relocations
    {
        public enum BASE_RELOCATION_TYPE
        {
            ABSOLUTE = 0,
            HIGH = 1,
            LOW = 2,
            HIGHLOW = 3,
            HIGHADJ = 4,
            JMPADDR = 5,
            MIPS_JMPADDR16 = 9,
            DIR64 = 10
        }
        public struct Page
        {
            public uint address;
            public uint size;
            public uint count;
        }
        public struct Reloc
        {
            public ushort offset;
            public BASE_RELOCATION_TYPE type;
        }

        private uint imageBase;
        private uint virtualAddress;
        private uint virtualSize;
        private uint RawAddress;
        private uint RawSize;

        private long addressVirtualSize;

        private SortedDictionary<uint, List<Reloc>> pages;
        private string path;

        public bool IsNotSaved { get; private set; }

        /// <summary>
        /// Open the file specified into the <paramref name="path"/>, read the relocation section
        /// and load it.
        /// </summary>
        /// <param name="path"></param>
        public Relocations(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();

            this.path = path;
            this.IsNotSaved = false;

            BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read));

            if (br.ReadInt16() != 0x5A4D) // MZ signature
            {
                br.Close();
                throw new InvalidOperationException("MZ");
            }

            br.BaseStream.Seek(0x3C, SeekOrigin.Begin); // go to ptr to COFF File Header
            br.BaseStream.Seek(br.ReadInt32(), SeekOrigin.Begin); // go to COFF File Header

            if (br.ReadInt32() != 0x00004550) // PE\0\0
            {
                br.Close();
                throw new InvalidOperationException("PE");
            }

            br.ReadUInt16(); // machine ID. Ignored
            uint numbersOfSections = br.ReadUInt16();

            br.BaseStream.Seek(20 - 4, SeekOrigin.Current); // go to magic number (PE or PE+ = x86 or x64)

            if (br.ReadInt16() != 0x010B)
            {
                br.Close();
                throw new InvalidOperationException("X86");
            }

            br.BaseStream.Seek(26, SeekOrigin.Current); // go to ImageBase
            imageBase = br.ReadUInt32();
            br.BaseStream.Seek(64 + 40, SeekOrigin.Current); // go to Data Directories -> Base Relocation Table

            virtualAddress = br.ReadUInt32();
            addressVirtualSize = br.BaseStream.Position;
            virtualSize = br.ReadUInt32();

            br.BaseStream.Seek(80, SeekOrigin.Current); // jump to Section Table

            // find the RAW address/size
            RawAddress = 0;
            RawSize = 0;

            for (int i = 0; i < numbersOfSections; i++)
            {
                br.BaseStream.Seek(12, SeekOrigin.Current);

                if (br.ReadUInt32() == virtualAddress)
                {
                    RawSize = br.ReadUInt32();
                    RawAddress = br.ReadUInt32();
                    break;
                }

                br.BaseStream.Seek(24, SeekOrigin.Current); // place the pointer to the next section
            }

            if (RawAddress == 0x00 || RawSize == 0x00)
            {
                br.Close();
                throw new InvalidOperationException("RAW");
            }

            // reading relocation section
            br.BaseStream.Seek(RawAddress, SeekOrigin.Begin);

            pages = new SortedDictionary<uint, List<Reloc>>();

            while (br.BaseStream.Position < RawAddress + virtualSize) // 4K block loop
            {
                uint address = br.ReadUInt32();
                uint size = br.ReadUInt32();
                uint count = (size - 8) / 2;

                List<Reloc> relocs = new List<Reloc>();

                for (int i = 0; i < count; i++) // offsets loop
                {
                    ushort data = br.ReadUInt16();
                    BASE_RELOCATION_TYPE type = (BASE_RELOCATION_TYPE)((data & 0xF000) >> 12);
                    ushort offset = (ushort)(data & 0x0FFF);

                    Reloc reloc = new Reloc();
                    reloc.offset = offset;
                    reloc.type = type;

                    relocs.Add(reloc);
                }

                pages.Add(address, relocs);
            }

            br.Close();
        }

        /// <summary>
        /// Edit an specific address
        /// </summary>
        /// <param name="address">Old address</param>
        /// <param name="newAddress">New address</param>
        /// <param name="newType">New type</param>
        /// <returns>True if edited with success, else false</returns>
        public bool EditRelocation(uint address, uint newAddress, BASE_RELOCATION_TYPE newType)
        {
            uint oldAddress = (address & 0xFFFFF000) - imageBase;
            ushort oldOffset = (ushort)(address & 0x00000FFF);

            BASE_RELOCATION_TYPE oldType = BASE_RELOCATION_TYPE.ABSOLUTE;
            List<Reloc> relocs;
            
            if (!pages.TryGetValue(oldAddress, out relocs))
                return false;

            foreach (Reloc reloc in relocs)
            {
                if (reloc.offset == oldOffset)
                {
                    oldType = reloc.type;
                    break;
                }
            }

            if (oldType == BASE_RELOCATION_TYPE.ABSOLUTE)
                return false;

            // delete old address and add new address. If not success, restore old address
            if (!DeleteRelocation(address))
                return false;

            if (AddRelocation(newAddress, newType) <= 0)
            {
                AddRelocation(address, oldType);
                return false;
            }

            IsNotSaved = true;
            return true;
        }

        /// <summary>
        /// Remove a specific address
        /// </summary>
        /// <param name="address">Address to remove</param>
        /// <returns>True if removed with success, else false</returns>
        public bool DeleteRelocation(uint address)
        {
            List<Reloc> relocs;

            // search if 4K address exists
            if (!pages.TryGetValue((address & 0xFFFFF000) - imageBase, out relocs))
                return false;

            ushort offset = (ushort)(address & 0x0FFF);

            // search if offset exists
            foreach (Reloc reloc in relocs)
            {
                if (reloc.offset == offset && reloc.type != BASE_RELOCATION_TYPE.ABSOLUTE)
                {
                    relocs.Remove(reloc);
                    virtualSize -= 2;

                    if (relocs.Count % 2 != 0) // align in 32bits
                    {
                        bool isAlignDeleted = false;

                        foreach (Reloc item in relocs) // search if align already exists
                        {
                            if (item.offset == 0 && item.type == BASE_RELOCATION_TYPE.ABSOLUTE)
                            {
                                relocs.Remove(item);
                                isAlignDeleted = true;
                                virtualSize -= 2;
                                break;
                            }
                        }

                        if (!isAlignDeleted) // if no align reloc found, add it
                        {
                            Reloc item = new Reloc();
                            item.offset = 0;
                            item.type = BASE_RELOCATION_TYPE.ABSOLUTE;

                            relocs.Add(item);
                            virtualSize += 2;
                        }
                    }

                    if (relocs.Count == 0) // remove page if nothing offset
                    {
                        pages.Remove((address & 0xFFFFF000) - imageBase);
                        virtualSize -= 8;
                    }

                    IsNotSaved = true;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Add a relocation address
        /// </summary>
        /// <param name="address">Address to add</param>
        /// <param name="type">Type of relocation</param>
        /// <returns>-1 if duplicated, 0 if not added, 1 if added a page and 2 if added only in reloc of page</returns>
        public int AddRelocation(uint address, BASE_RELOCATION_TYPE type)
        {
            if (address < imageBase)
                return 0;

            uint page = (address & 0xFFFFF000) - imageBase;
            ushort offset = (ushort)(address & 0x00000FFF);

            if (!pages.ContainsKey(page)) // create a new page if doesn't exists
            {
                if (RawSize - virtualSize < 12)
                    return 0;

                List<Reloc> relocs = new List<Reloc>();

                Reloc reloc = new Reloc();
                reloc.offset = offset;
                reloc.type = type;
                relocs.Add(reloc);

                reloc = new Reloc();
                reloc.offset = 0;
                reloc.type = BASE_RELOCATION_TYPE.ABSOLUTE;
                relocs.Add(reloc);

                pages.Add(page, relocs);

                virtualSize += 12;

                IsNotSaved = true;
                return 1;
            }
            else // just added the offset
            {
                List<Reloc> relocs;

                if (!pages.TryGetValue(page, out relocs))
                    return 0;

                foreach (Reloc item in relocs) // search if address already present
                {
                    if (item.offset == offset && item.type != BASE_RELOCATION_TYPE.ABSOLUTE)
                        return -1;
                }

                if (relocs.Count % 2 == 0) // align in 32bits
                {
                    bool isAlignDeleted = false;

                    foreach (Reloc item in relocs) // search if align already exists
                    {
                        if (item.offset == 0 && item.type == BASE_RELOCATION_TYPE.ABSOLUTE)
                        {
                            relocs.Remove(item);
                            isAlignDeleted = true;
                            virtualSize -= 2;
                            break;
                        }
                    }

                    if (!isAlignDeleted) // if no align reloc found, add it
                    {
                        if (RawSize - virtualSize < 4)
                            return 0;

                        Reloc item = new Reloc();
                        item.offset = 0;
                        item.type = BASE_RELOCATION_TYPE.ABSOLUTE;

                        relocs.Add(item);
                        virtualSize += 2;
                    }
                }

                Reloc reloc = new Reloc();
                reloc.offset = offset;
                reloc.type = type;

                relocs.Add(reloc);

                virtualSize += 2;

                IsNotSaved = true;
                return 2;
            }
        }

        /// <summary>
        /// Obtain a list of pages available
        /// </summary>
        /// <returns>A list of pages available</returns>
        public List<Page> GetPages()
        {
            List<Page> result = new List<Page>();

            SortedDictionary<uint, List<Reloc>>.Enumerator enumerator = pages.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Page p = new Page();

                p.address = enumerator.Current.Key + imageBase;
                p.count = (uint)enumerator.Current.Value.Count;
                p.size = (p.count * 2) + 8;

                result.Add(p);
            }

            return result;
        }

        /// <summary>
        /// Try to obtain a list of relocations for an address given
        /// </summary>
        /// <param name="baseAddress">Base address of relocations</param>
        /// <param name="relocs">List of relocations for this address</param>
        /// <returns>True if relocations given with success, else false</returns>
        public bool TryGetRelocs(uint baseAddress, out List<Reloc> relocs)
        {
            return pages.TryGetValue(baseAddress - imageBase, out relocs);
        }

        /// <summary>
        /// Obtain the Size of Relocation section into the RAM
        /// </summary>
        /// <returns>The virtual size</returns>
        public uint GetVirtuallSize()
        {
            return virtualSize;
        }

        /// <summary>
        /// Obtain the Size of Relocation section into the disk
        /// </summary>
        /// <returns>The RAW size</returns>
        public uint GetRawSize()
        {
            return RawSize;
        }

        /// <summary>
        /// Obtain the file path
        /// </summary>
        /// <returns>The file path</returns>
        public string GetPath()
        {
            return path;
        }

        /// <summary>
        /// Write the relocations section into the file
        /// </summary>
        /// <returns>True if written with success, else false</returns>
        public bool WriteRelocations(string newPath = "")
        {
            if (!File.Exists(path))
                return false;

            if (!string.IsNullOrEmpty(newPath) && newPath != path) // save as
            {
                try
                {
                    File.Copy(path, newPath, true);
                    path = newPath;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.None));

            // write new relocation size
            bw.BaseStream.Seek(addressVirtualSize, SeekOrigin.Begin);
            bw.Write((uint)virtualSize);

            // go to beginning of relocation section
            bw.BaseStream.Seek(RawAddress, SeekOrigin.Begin);

            foreach (KeyValuePair<uint, List<Reloc>> page in pages)
            {
                // write page
                bw.Write(page.Key);
                bw.Write(page.Value.Count * 2 + 8);

                foreach (Reloc reloc in page.Value)
                {
                    // write reloc
                    ushort temp = (ushort)((ushort)reloc.type << 12);
                    temp += reloc.offset;
                    bw.Write(temp);
                }
            }

            // fill the end with null bytes
            while (bw.BaseStream.Position < RawAddress + RawSize)
                bw.Write((int)0x00000000);

            bw.Close();

            IsNotSaved = false;
            return true;
        }
    }
}
