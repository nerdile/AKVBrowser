using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Azure.Core;
using Azure.Identity;

namespace SecretsGui.Views
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        public string KeyVaultUrl
        {
            get => keyVaultBox.Text;
            set => keyVaultBox.Text = value;
        }

        public class NamedItem<T>
        {
            public T Item;
            public string DisplayName => Item.ToString();

            public NamedItem(T item)
            {
                Item = item;
            }
        }

        public List<AzureConnection> Connections { get; } = new List<AzureConnection>
        {
            new AzureConnection.OpenInBrowser(),
            new AzureConnection.UseDefaultCredential(),
            new AzureConnection.CreateNewConnection()
        };

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            connectionBox.DisplayMember = "DisplayName";
            connectionBox.DataSource = Connections;
            connectionBox.SelectedIndex = 0;
        }

        public TokenCredential Connection
        {
            get
            {
                var item = connectionBox.SelectedItem as AzureConnection;
                var asCred = item?.GetCredential();
                return asCred ?? new InteractiveBrowserCredential();
            }
        }
    }
}
