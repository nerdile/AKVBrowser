using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using NerdileSnippets.WinFormsHelpers;
using SecretsGui.AKV;
using SecretsGui.Views;

namespace SecretsGui
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var initialSecretStore = await TryOpenNewConnection(Configuration["keyVaultUri"]);

            var view = new VaultBrowserViewForm(initialSecretStore.Name, initialSecretStore);
            context.AddForm(view);
            view.Show();

            if (context.HasAnyWindows)
                Application.Run(context);
        }

        public static readonly IConfiguration Configuration = GetConfig();

        private static IConfiguration GetConfig()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appSettings.json", true, true)
                    .AddJsonFile("appSettings.json.user", true, true)
                    .AddEnvironmentVariables("NERDILE")
                ;

            return builder.Build();
        }

        public static async Task<AKVBrowserViewModel> TryOpenNewConnection(string keyVaultUrl)
        {
            var connectForm = new ConnectionForm { KeyVaultUrl = keyVaultUrl };

            while (true)
            {
                if (connectForm.ShowDialog() != DialogResult.OK)
                {
                    break;
                }

                var cred = connectForm.Connection;
                try
                {
                    var initialSecretStore =
                        await AKVBrowserViewModel.TryConnectAsync(connectForm.KeyVaultUrl, cred);
                    if (initialSecretStore == null)
                    {
                        MessageBox.Show(
                            "Access denied when trying to connect to the key vault.  Try using a different Azure connection, signing in with a different account, or verify that this account has access to list secrets in this vault.",
                            "Access denied");
                    }

                    return initialSecretStore;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to connect:\r\n\r\n{ex}", "Error connecting to key vault");
                }
            }

            return null;
        }

        public static async Task StartNewConnection()
        {
            var initialSecretStore = await TryOpenNewConnection(Configuration["keyVaultUri"]);
            var view = new VaultBrowserViewForm(initialSecretStore.Name, initialSecretStore);
            context.AddForm(view);
            view.Show();
        }

        private static ExitWhenFormsClose context = new ExitWhenFormsClose();
    }
}
