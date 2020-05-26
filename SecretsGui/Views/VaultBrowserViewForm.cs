using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdileSnippets.WinFormsHelpers;
using SecretsGui.Models;

namespace SecretsGui.Views
{
    public sealed partial class VaultBrowserViewForm : Form
    {
        private readonly VaultBrowserViewModel _viewModel;

        public VaultBrowserViewForm(string name, VaultBrowserViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
            Text = $"{name} - Secrets";
        }

        private void SecretListForm_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            secretsList.Clear();
            var secretsNodes = secretsTree.Nodes["secretsNode"];
            secretsNodes.Nodes.Clear();
            var certsNodes = secretsTree.Nodes["certificatesNode"];
            certsNodes.Nodes.Clear();

            foreach (var s in _viewModel.Secrets)
            {
                secretsList.Items.Add(s.Name, s.Name, 0);
                secretsNodes.Nodes.Add($"secret:{s.Name}", s.Name, "secret", "secret");
            }

            foreach (var c in _viewModel.Certs)
            {
                certsNodes.Nodes.Add($"cert:{c.Name}", c.Name, "cert", "cert");
            }
        }

        private async void secretsList_DoubleClick(object sender, EventArgs e)
        {
            if (secretsList.SelectedItems.Count > 0)
            {
                await ShowSecret(secretsList.SelectedItems[0].Name);
            }
        }

        private async Task ShowSecret(string name)
        {
            var value = await _viewModel.GetSecretValue(name);

            new SecretValueForm(name, value).Show();
        }

        private async Task HandleNodeClick(TreeNode n)
        {
            if (n == null) return;

            if (n.Name.StartsWith("secret:"))
                await ShowSecret(n.Name.Substring(7));
            else if (n.Name.StartsWith("cert:"))
                await ShowCert(n.Name.Substring(5));
        }

        private async Task ShowCert(string name)
        {
            new CertEntryForm(name,
                await _viewModel.GetCertSubjectName(name),
                await _viewModel.GetCertThumbprint(name),
                async filename => await _viewModel.SaveCertPublicKeyToFile(name, filename),
                async filename => await _viewModel.SaveCertPrivateKeyToFile(name, filename)
                ).Show();
        }

        private async void secretsTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            await OnError.ShowMessageBox(async () =>
            {
                await HandleNodeClick(e.Node);
            });
        }

        private async void secretsTree_KeyPress(object sender, KeyPressEventArgs e)
        {
            await OnError.ShowMessageBox(async () =>
            {
                if (e.KeyChar == 13 && secretsTree.SelectedNode != null)
                    await HandleNodeClick(secretsTree.SelectedNode);
            });
        }
    }
}
