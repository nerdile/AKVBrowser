namespace SecretsGui.Views
{
    partial class ConnectionForm
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
            this.connectionBoxLabel = new System.Windows.Forms.Label();
            this.connectionBox = new System.Windows.Forms.ComboBox();
            this.keyVaultBoxLabel = new System.Windows.Forms.Label();
            this.keyVaultBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionBoxLabel
            // 
            this.connectionBoxLabel.AutoSize = true;
            this.connectionBoxLabel.Location = new System.Drawing.Point(17, 25);
            this.connectionBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionBoxLabel.Name = "connectionBoxLabel";
            this.connectionBoxLabel.Size = new System.Drawing.Size(156, 25);
            this.connectionBoxLabel.TabIndex = 0;
            this.connectionBoxLabel.Text = "Azure Connection:";
            // 
            // connectionBox
            // 
            this.connectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionBox.FormattingEnabled = true;
            this.connectionBox.Items.AddRange(new object[] {
            "Sign in through my browser",
            "DefaultAzureCredential",
            "(New connection...)"});
            this.connectionBox.Location = new System.Drawing.Point(201, 20);
            this.connectionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(220, 33);
            this.connectionBox.TabIndex = 1;
            // 
            // keyVaultBoxLabel
            // 
            this.keyVaultBoxLabel.AutoSize = true;
            this.keyVaultBoxLabel.Location = new System.Drawing.Point(17, 90);
            this.keyVaultBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keyVaultBoxLabel.Name = "keyVaultBoxLabel";
            this.keyVaultBoxLabel.Size = new System.Drawing.Size(174, 25);
            this.keyVaultBoxLabel.TabIndex = 0;
            this.keyVaultBoxLabel.Text = "Azure Key Vault URL:";
            // 
            // keyVaultBox
            // 
            this.keyVaultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyVaultBox.Location = new System.Drawing.Point(201, 85);
            this.keyVaultBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyVaultBox.Name = "keyVaultBox";
            this.keyVaultBox.Size = new System.Drawing.Size(220, 31);
            this.keyVaultBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(316, 144);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(107, 38);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(200, 144);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 38);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(440, 196);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.keyVaultBox);
            this.Controls.Add(this.keyVaultBoxLabel);
            this.Controls.Add(this.connectionBox);
            this.Controls.Add(this.connectionBoxLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(442, 218);
            this.Name = "ConnectionForm";
            this.Text = "Connect to AKV";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectionBoxLabel;
        private System.Windows.Forms.ComboBox connectionBox;
        private System.Windows.Forms.Label keyVaultBoxLabel;
        private System.Windows.Forms.TextBox keyVaultBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}