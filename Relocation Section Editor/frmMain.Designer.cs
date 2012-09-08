namespace Relocation_Section_Editor
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sptMain = new System.Windows.Forms.SplitContainer();
            this.grpPage = new System.Windows.Forms.GroupBox();
            this.lvPage = new System.Windows.Forms.ListView();
            this.colPageRVA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBlockSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmnuPages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuPagesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuPagesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRelocation = new System.Windows.Forms.GroupBox();
            this.lvRelocation = new System.Windows.Forms.ListView();
            this.colOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmnuRelocations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuRelocationsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRelocationsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuRelocationsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.staInfo = new System.Windows.Forms.StatusStrip();
            this.staLblCurrentSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.staLblMaxSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.staPbSize = new System.Windows.Forms.ToolStripProgressBar();
            this.mnuMainFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.mnuMain.SuspendLayout();
            this.sptMain.Panel1.SuspendLayout();
            this.sptMain.Panel2.SuspendLayout();
            this.sptMain.SuspendLayout();
            this.grpPage.SuspendLayout();
            this.cmnuPages.SuspendLayout();
            this.grpRelocation.SuspendLayout();
            this.cmnuRelocations.SuspendLayout();
            this.staInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(796, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFileOpen,
            this.mnuMainFileSave,
            this.mnuMainFileSaveAs,
            this.toolStripSeparator1,
            this.mnuMainFileExit});
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainFile.Text = "&File";
            // 
            // mnuMainFileOpen
            // 
            this.mnuMainFileOpen.Name = "mnuMainFileOpen";
            this.mnuMainFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuMainFileOpen.Size = new System.Drawing.Size(191, 22);
            this.mnuMainFileOpen.Text = "&Open...";
            this.mnuMainFileOpen.Click += new System.EventHandler(this.mnuMainFileOpen_Click);
            // 
            // mnuMainFileSave
            // 
            this.mnuMainFileSave.Name = "mnuMainFileSave";
            this.mnuMainFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuMainFileSave.Size = new System.Drawing.Size(191, 22);
            this.mnuMainFileSave.Text = "&Save";
            this.mnuMainFileSave.Click += new System.EventHandler(this.mnuMainFileSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuMainFileExit
            // 
            this.mnuMainFileExit.Name = "mnuMainFileExit";
            this.mnuMainFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuMainFileExit.Size = new System.Drawing.Size(191, 22);
            this.mnuMainFileExit.Text = "&Exit";
            this.mnuMainFileExit.Click += new System.EventHandler(this.mnuMainFileExit_Click);
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainHelpAbout});
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(24, 20);
            this.mnuMainHelp.Text = "&?";
            // 
            // mnuMainHelpAbout
            // 
            this.mnuMainHelpAbout.Name = "mnuMainHelpAbout";
            this.mnuMainHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuMainHelpAbout.Text = "&About";
            this.mnuMainHelpAbout.Click += new System.EventHandler(this.mnuMainHelpAbout_Click);
            // 
            // sptMain
            // 
            this.sptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sptMain.Location = new System.Drawing.Point(0, 24);
            this.sptMain.Name = "sptMain";
            // 
            // sptMain.Panel1
            // 
            this.sptMain.Panel1.Controls.Add(this.grpPage);
            // 
            // sptMain.Panel2
            // 
            this.sptMain.Panel2.Controls.Add(this.grpRelocation);
            this.sptMain.Size = new System.Drawing.Size(796, 416);
            this.sptMain.SplitterDistance = 228;
            this.sptMain.TabIndex = 1;
            // 
            // grpPage
            // 
            this.grpPage.Controls.Add(this.lvPage);
            this.grpPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPage.Location = new System.Drawing.Point(0, 0);
            this.grpPage.Name = "grpPage";
            this.grpPage.Size = new System.Drawing.Size(228, 416);
            this.grpPage.TabIndex = 0;
            this.grpPage.TabStop = false;
            this.grpPage.Text = "Page";
            // 
            // lvPage
            // 
            this.lvPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPageRVA,
            this.colBlockSize,
            this.colCount});
            this.lvPage.ContextMenuStrip = this.cmnuPages;
            this.lvPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPage.FullRowSelect = true;
            this.lvPage.GridLines = true;
            this.lvPage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPage.HideSelection = false;
            this.lvPage.Location = new System.Drawing.Point(3, 16);
            this.lvPage.MultiSelect = false;
            this.lvPage.Name = "lvPage";
            this.lvPage.Size = new System.Drawing.Size(222, 397);
            this.lvPage.TabIndex = 0;
            this.lvPage.UseCompatibleStateImageBehavior = false;
            this.lvPage.View = System.Windows.Forms.View.Details;
            this.lvPage.SelectedIndexChanged += new System.EventHandler(this.lvPage_SelectedIndexChanged);
            // 
            // colPageRVA
            // 
            this.colPageRVA.Text = "Page RVA";
            this.colPageRVA.Width = 75;
            // 
            // colBlockSize
            // 
            this.colBlockSize.Text = "Block Size";
            this.colBlockSize.Width = 75;
            // 
            // colCount
            // 
            this.colCount.Text = "# items";
            this.colCount.Width = 50;
            // 
            // cmnuPages
            // 
            this.cmnuPages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuPagesAdd,
            this.toolStripSeparator3,
            this.cmnuPagesDelete});
            this.cmnuPages.Name = "cmnuPages";
            this.cmnuPages.Size = new System.Drawing.Size(173, 54);
            // 
            // cmnuPagesAdd
            // 
            this.cmnuPagesAdd.Name = "cmnuPagesAdd";
            this.cmnuPagesAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmnuPagesAdd.Size = new System.Drawing.Size(172, 22);
            this.cmnuPagesAdd.Text = "&Add";
            this.cmnuPagesAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // cmnuPagesDelete
            // 
            this.cmnuPagesDelete.Name = "cmnuPagesDelete";
            this.cmnuPagesDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.cmnuPagesDelete.Size = new System.Drawing.Size(172, 22);
            this.cmnuPagesDelete.Text = "&Delete";
            this.cmnuPagesDelete.Click += new System.EventHandler(this.cmnuPagesDelete_Click);
            // 
            // grpRelocation
            // 
            this.grpRelocation.Controls.Add(this.lvRelocation);
            this.grpRelocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRelocation.Location = new System.Drawing.Point(0, 0);
            this.grpRelocation.Name = "grpRelocation";
            this.grpRelocation.Size = new System.Drawing.Size(564, 416);
            this.grpRelocation.TabIndex = 0;
            this.grpRelocation.TabStop = false;
            this.grpRelocation.Text = "Relocation";
            // 
            // lvRelocation
            // 
            this.lvRelocation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOffset,
            this.colType});
            this.lvRelocation.ContextMenuStrip = this.cmnuRelocations;
            this.lvRelocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRelocation.FullRowSelect = true;
            this.lvRelocation.GridLines = true;
            this.lvRelocation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRelocation.HideSelection = false;
            this.lvRelocation.Location = new System.Drawing.Point(3, 16);
            this.lvRelocation.MultiSelect = false;
            this.lvRelocation.Name = "lvRelocation";
            this.lvRelocation.Size = new System.Drawing.Size(558, 397);
            this.lvRelocation.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvRelocation.TabIndex = 0;
            this.lvRelocation.UseCompatibleStateImageBehavior = false;
            this.lvRelocation.View = System.Windows.Forms.View.Details;
            // 
            // colOffset
            // 
            this.colOffset.Text = "Offset";
            this.colOffset.Width = 70;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 220;
            // 
            // cmnuRelocations
            // 
            this.cmnuRelocations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuRelocationsAdd,
            this.cmnuRelocationsEdit,
            this.toolStripSeparator2,
            this.cmnuRelocationsDelete});
            this.cmnuRelocations.Name = "cmnuRelocations";
            this.cmnuRelocations.Size = new System.Drawing.Size(153, 98);
            // 
            // cmnuRelocationsAdd
            // 
            this.cmnuRelocationsAdd.Name = "cmnuRelocationsAdd";
            this.cmnuRelocationsAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cmnuRelocationsAdd.Size = new System.Drawing.Size(152, 22);
            this.cmnuRelocationsAdd.Text = "&Add";
            this.cmnuRelocationsAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // cmnuRelocationsEdit
            // 
            this.cmnuRelocationsEdit.Name = "cmnuRelocationsEdit";
            this.cmnuRelocationsEdit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cmnuRelocationsEdit.Size = new System.Drawing.Size(152, 22);
            this.cmnuRelocationsEdit.Text = "&Edit";
            this.cmnuRelocationsEdit.Click += new System.EventHandler(this.mnuRelocationsEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // cmnuRelocationsDelete
            // 
            this.cmnuRelocationsDelete.Name = "cmnuRelocationsDelete";
            this.cmnuRelocationsDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmnuRelocationsDelete.Size = new System.Drawing.Size(152, 22);
            this.cmnuRelocationsDelete.Text = "&Delete";
            this.cmnuRelocationsDelete.Click += new System.EventHandler(this.cmuRelocationsDelete_Click);
            // 
            // staInfo
            // 
            this.staInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staLblCurrentSize,
            this.staLblMaxSize,
            this.staPbSize});
            this.staInfo.Location = new System.Drawing.Point(0, 440);
            this.staInfo.Name = "staInfo";
            this.staInfo.Size = new System.Drawing.Size(796, 22);
            this.staInfo.TabIndex = 1;
            this.staInfo.Text = "statusStrip1";
            // 
            // staLblCurrentSize
            // 
            this.staLblCurrentSize.Name = "staLblCurrentSize";
            this.staLblCurrentSize.Size = new System.Drawing.Size(72, 17);
            this.staLblCurrentSize.Text = "Current size:";
            // 
            // staLblMaxSize
            // 
            this.staLblMaxSize.Name = "staLblMaxSize";
            this.staLblMaxSize.Size = new System.Drawing.Size(54, 17);
            this.staLblMaxSize.Text = "Max size:";
            // 
            // staPbSize
            // 
            this.staPbSize.Name = "staPbSize";
            this.staPbSize.Size = new System.Drawing.Size(100, 16);
            // 
            // mnuMainFileSaveAs
            // 
            this.mnuMainFileSaveAs.Name = "mnuMainFileSaveAs";
            this.mnuMainFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuMainFileSaveAs.Size = new System.Drawing.Size(191, 22);
            this.mnuMainFileSaveAs.Text = "Save &As...";
            this.mnuMainFileSaveAs.Click += new System.EventHandler(this.mnuMainFileSaveAs_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.sptMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.staInfo);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relocation Section Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.sptMain.Panel1.ResumeLayout(false);
            this.sptMain.Panel2.ResumeLayout(false);
            this.sptMain.ResumeLayout(false);
            this.grpPage.ResumeLayout(false);
            this.cmnuPages.ResumeLayout(false);
            this.grpRelocation.ResumeLayout(false);
            this.cmnuRelocations.ResumeLayout(false);
            this.staInfo.ResumeLayout(false);
            this.staInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileExit;
        private System.Windows.Forms.SplitContainer sptMain;
        private System.Windows.Forms.GroupBox grpPage;
        private System.Windows.Forms.ListView lvPage;
        private System.Windows.Forms.GroupBox grpRelocation;
        private System.Windows.Forms.ListView lvRelocation;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelpAbout;
        private System.Windows.Forms.ColumnHeader colPageRVA;
        private System.Windows.Forms.ColumnHeader colBlockSize;
        private System.Windows.Forms.ColumnHeader colOffset;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ContextMenuStrip cmnuRelocations;
        private System.Windows.Forms.ToolStripMenuItem cmnuRelocationsDelete;
        private System.Windows.Forms.StatusStrip staInfo;
        private System.Windows.Forms.ToolStripStatusLabel staLblCurrentSize;
        private System.Windows.Forms.ToolStripStatusLabel staLblMaxSize;
        private System.Windows.Forms.ToolStripProgressBar staPbSize;
        private System.Windows.Forms.ContextMenuStrip cmnuPages;
        private System.Windows.Forms.ToolStripMenuItem cmnuPagesDelete;
        private System.Windows.Forms.ToolStripMenuItem cmnuRelocationsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmnuPagesAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmnuRelocationsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileSaveAs;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

