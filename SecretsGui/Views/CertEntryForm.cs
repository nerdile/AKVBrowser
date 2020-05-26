using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdileSnippets.WinFormsHelpers;

namespace SecretsGui.Views
{
    public partial class CertEntryForm : Form
    {
        private readonly string _name;
        private readonly string _subject;
        private readonly string _thumbprint;
        private readonly Func<string, Task> _savePublicKey;
        private readonly Func<string, Task> _savePrivateKey;

        public CertEntryForm(string name, string subject, string thumbprint, Func<string, Task> savePublicKey, Func<string, Task> savePrivateKey)
        {
            _name = name;
            _savePublicKey = savePublicKey;
            _savePrivateKey = savePrivateKey;
            _thumbprint = thumbprint;
            _subject = subject;
            InitializeComponent();

            UpdateView();
        }

        private void UpdateView()
        {
            nameBox.Text = _name;
            subjectBox.Text = _subject;
            thumbprintBox.Text = _thumbprint;
            Text = _name;
        }

        private async void saveCerButton_Click(object sender, EventArgs e)
        {
            await OnError.ShowMessageBox(async () =>
            {
                if (saveCerDialog.ShowDialog() == DialogResult.OK)
                {
                    await _savePublicKey(saveCerDialog.FileName);
                }
            });
        }

        private async void savePfxButton_Click(object sender, EventArgs e)
        {
            await OnError.ShowMessageBox(async () =>
            {
                if (savePfxDialog.ShowDialog() == DialogResult.OK)
                {
                    await _savePrivateKey(savePfxDialog.FileName);
                }
            });
        }

        private void CertEntryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }
    }
}
