namespace SecretsGui.Views
{
    partial class CertEntryForm
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
            this.nameBoxLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.subjectBoxLabel = new System.Windows.Forms.Label();
            this.saveCerDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveCerButton = new System.Windows.Forms.Button();
            this.savePfxButton = new System.Windows.Forms.Button();
            this.savePfxDialog = new System.Windows.Forms.SaveFileDialog();
            this.thumbprintBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Location = new System.Drawing.Point(17, 25);
            this.nameBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(63, 25);
            this.nameBoxLabel.TabIndex = 0;
            this.nameBoxLabel.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameBox.Location = new System.Drawing.Point(130, 20);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(371, 31);
            this.nameBox.TabIndex = 1;
            // 
            // subjectBox
            // 
            this.subjectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectBox.BackColor = System.Drawing.SystemColors.Control;
            this.subjectBox.Location = new System.Drawing.Point(130, 68);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.ReadOnly = true;
            this.subjectBox.Size = new System.Drawing.Size(371, 31);
            this.subjectBox.TabIndex = 1;
            // 
            // subjectBoxLabel
            // 
            this.subjectBoxLabel.AutoSize = true;
            this.subjectBoxLabel.Location = new System.Drawing.Point(17, 73);
            this.subjectBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectBoxLabel.Name = "subjectBoxLabel";
            this.subjectBoxLabel.Size = new System.Drawing.Size(74, 25);
            this.subjectBoxLabel.TabIndex = 0;
            this.subjectBoxLabel.Text = "Subject:";
            // 
            // saveCerDialog
            // 
            this.saveCerDialog.DefaultExt = "cer";
            this.saveCerDialog.Filter = "Public key files|*.cer|All files|*.*";
            this.saveCerDialog.Title = "Export public key";
            // 
            // saveCerButton
            // 
            this.saveCerButton.Location = new System.Drawing.Point(130, 165);
            this.saveCerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveCerButton.Name = "saveCerButton";
            this.saveCerButton.Size = new System.Drawing.Size(221, 38);
            this.saveCerButton.TabIndex = 2;
            this.saveCerButton.Text = "Export public key...";
            this.saveCerButton.UseVisualStyleBackColor = true;
            this.saveCerButton.Click += new System.EventHandler(this.saveCerButton_Click);
            // 
            // savePfxButton
            // 
            this.savePfxButton.Location = new System.Drawing.Point(130, 213);
            this.savePfxButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savePfxButton.Name = "savePfxButton";
            this.savePfxButton.Size = new System.Drawing.Size(221, 38);
            this.savePfxButton.TabIndex = 2;
            this.savePfxButton.Text = "Export private key...";
            this.savePfxButton.UseVisualStyleBackColor = true;
            this.savePfxButton.Click += new System.EventHandler(this.savePfxButton_Click);
            // 
            // savePfxDialog
            // 
            this.savePfxDialog.DefaultExt = "pfx";
            this.savePfxDialog.Filter = "PFX files|*.pfx|All files|*.*";
            this.savePfxDialog.Title = "Export private key";
            // 
            // thumbprintBox
            // 
            this.thumbprintBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbprintBox.BackColor = System.Drawing.SystemColors.Control;
            this.thumbprintBox.Location = new System.Drawing.Point(130, 117);
            this.thumbprintBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thumbprintBox.Name = "thumbprintBox";
            this.thumbprintBox.ReadOnly = true;
            this.thumbprintBox.Size = new System.Drawing.Size(371, 31);
            this.thumbprintBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thumbprint:";
            // 
            // CertEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thumbprintBox);
            this.Controls.Add(this.savePfxButton);
            this.Controls.Add(this.saveCerButton);
            this.Controls.Add(this.subjectBoxLabel);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameBoxLabel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(522, 291);
            this.Name = "CertEntryForm";
            this.Text = "Name";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CertEntryForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label subjectBoxLabel;
        private System.Windows.Forms.SaveFileDialog saveCerDialog;
        private System.Windows.Forms.Button saveCerButton;
        private System.Windows.Forms.Button savePfxButton;
        private System.Windows.Forms.SaveFileDialog savePfxDialog;
        private System.Windows.Forms.TextBox thumbprintBox;
        private System.Windows.Forms.Label label1;
    }
}