namespace Relocation_Section_Editor
{
    partial class frmEditRelocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHexa = new System.Windows.Forms.Label();
            this.lblNewAddress = new System.Windows.Forms.Label();
            this.lblHexa2 = new System.Windows.Forms.Label();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(127, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(26, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "HIGH",
            "LOW",
            "HIGHLOW",
            "HIGHADJ",
            "JMPADDR",
            "MIPS_JMPADDR16",
            "DIR64"});
            this.cboType.Location = new System.Drawing.Point(93, 64);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(122, 21);
            this.cboType.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(39, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(93, 12);
            this.txtAddress.MaxLength = 8;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(68, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 15);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Location = new System.Drawing.Point(77, 15);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(18, 13);
            this.lblHexa.TabIndex = 8;
            this.lblHexa.Text = "0x";
            // 
            // lblNewAddress
            // 
            this.lblNewAddress.AutoSize = true;
            this.lblNewAddress.Location = new System.Drawing.Point(0, 38);
            this.lblNewAddress.Name = "lblNewAddress";
            this.lblNewAddress.Size = new System.Drawing.Size(73, 13);
            this.lblNewAddress.TabIndex = 0;
            this.lblNewAddress.Text = "New Address:";
            // 
            // lblHexa2
            // 
            this.lblHexa2.AutoSize = true;
            this.lblHexa2.Location = new System.Drawing.Point(77, 40);
            this.lblHexa2.Name = "lblHexa2";
            this.lblHexa2.Size = new System.Drawing.Size(18, 13);
            this.lblHexa2.TabIndex = 1;
            this.lblHexa2.Text = "0x";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(93, 38);
            this.txtNewAddress.MaxLength = 8;
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(68, 20);
            this.txtNewAddress.TabIndex = 2;
            this.txtNewAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewAddress_KeyPress);
            this.txtNewAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewAddress_KeyUp);
            // 
            // frmEditRelocation
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(229, 121);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.lblHexa2);
            this.Controls.Add(this.lblNewAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHexa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditRelocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Relocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblNewAddress;
        private System.Windows.Forms.Label lblHexa2;
        private System.Windows.Forms.TextBox txtNewAddress;
    }
}