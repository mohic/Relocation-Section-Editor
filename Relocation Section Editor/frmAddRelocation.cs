using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Relocation_Section_Editor
{
    public partial class frmAddRelocation : Form
    {
        private uint address;
        private Relocations.BASE_RELOCATION_TYPE type;

        public frmAddRelocation()
        {
            InitializeComponent();
        }

        private void frmAddRelocation_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!uint.TryParse(txtAddress.Text, System.Globalization.NumberStyles.AllowHexSpecifier, null, out address))
            {
                MessageBox.Show("\"" + txtAddress.Text.ToUpper() + "\" isn't a valid address");
                return;
            }

            type = (Relocations.BASE_RELOCATION_TYPE)(cboType.SelectedIndex + 1);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chars = "0123456789abcdefABCDEF";

            if (e.KeyChar == (char)Keys.Back)
                return;

            if (!chars.Contains(e.KeyChar.ToString()))
                e.Handled = true;
        }

        public uint GetAddress()
        {
            return address;
        }

        public Relocations.BASE_RELOCATION_TYPE GetRelocType()
        {
            return type;
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                txtAddress.Text = Clipboard.GetText();
                txtAddress.SelectionStart = txtAddress.Text.Length;
                txtAddress.SelectionLength = 0;
            }
        }
    }
}
