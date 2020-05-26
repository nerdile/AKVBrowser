namespace SecretsGui.Views
{
    sealed partial class VaultBrowserViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Secrets");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Certificates");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaultBrowserViewForm));
            this.secretsList = new System.Windows.Forms.ListView();
            this.secretsTree = new System.Windows.Forms.TreeView();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // secretsList
            // 
            this.secretsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secretsList.HideSelection = false;
            this.secretsList.Location = new System.Drawing.Point(0, 0);
            this.secretsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secretsList.Name = "secretsList";
            this.secretsList.Size = new System.Drawing.Size(624, 362);
            this.secretsList.TabIndex = 0;
            this.secretsList.UseCompatibleStateImageBehavior = false;
            this.secretsList.View = System.Windows.Forms.View.List;
            this.secretsList.Visible = false;
            this.secretsList.DoubleClick += new System.EventHandler(this.secretsList_DoubleClick);
            // 
            // secretsTree
            // 
            this.secretsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secretsTree.ImageIndex = 0;
            this.secretsTree.ImageList = this.treeImages;
            this.secretsTree.Location = new System.Drawing.Point(0, 0);
            this.secretsTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secretsTree.Name = "secretsTree";
            treeNode1.ImageKey = "secret";
            treeNode1.Name = "secretsNode";
            treeNode1.SelectedImageKey = "secret";
            treeNode1.Text = "Secrets";
            treeNode2.ImageKey = "cert";
            treeNode2.Name = "certificatesNode";
            treeNode2.Text = "Certificates";
            this.secretsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.secretsTree.SelectedImageIndex = 0;
            this.secretsTree.Size = new System.Drawing.Size(624, 362);
            this.secretsTree.TabIndex = 1;
            this.secretsTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.secretsTree_NodeMouseDoubleClick);
            this.secretsTree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secretsTree_KeyPress);
            // 
            // treeImages
            // 
            this.treeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "cert");
            this.treeImages.Images.SetKeyName(1, "secret");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // VaultBrowserViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Controls.Add(this.secretsTree);
            this.Controls.Add(this.secretsList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VaultBrowserViewForm";
            this.Text = "MyKeyVaultName - Secrets";
            this.Load += new System.EventHandler(this.SecretListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView secretsList;
        private System.Windows.Forms.TreeView secretsTree;
        private System.Windows.Forms.ImageList treeImages;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

