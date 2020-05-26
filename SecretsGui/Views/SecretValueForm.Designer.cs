namespace SecretsGui.Views
{
    partial class SecretValueForm
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
            this.valueBox = new System.Windows.Forms.TextBox();
            this.valueBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Location = new System.Drawing.Point(12, 15);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(42, 15);
            this.nameBoxLabel.TabIndex = 0;
            this.nameBoxLabel.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameBox.Location = new System.Drawing.Point(74, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(102, 23);
            this.nameBox.TabIndex = 1;
            // 
            // valueBox
            // 
            this.valueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueBox.BackColor = System.Drawing.SystemColors.Control;
            this.valueBox.Location = new System.Drawing.Point(74, 41);
            this.valueBox.Name = "valueBox";
            this.valueBox.ReadOnly = true;
            this.valueBox.Size = new System.Drawing.Size(102, 23);
            this.valueBox.TabIndex = 1;
            // 
            // valueBoxLabel
            // 
            this.valueBoxLabel.AutoSize = true;
            this.valueBoxLabel.Location = new System.Drawing.Point(12, 44);
            this.valueBoxLabel.Name = "valueBoxLabel";
            this.valueBoxLabel.Size = new System.Drawing.Size(38, 15);
            this.valueBoxLabel.TabIndex = 0;
            this.valueBoxLabel.Text = "Value:";
            // 
            // SecretValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 75);
            this.Controls.Add(this.valueBoxLabel);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameBoxLabel);
            this.KeyPreview = true;
            this.Name = "SecretValueForm";
            this.Text = "Name";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecretValueForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label valueBoxLabel;
    }
}