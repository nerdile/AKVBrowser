using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Azure.Core;
using NerdileSnippets;
using SecretsGui.Models;

namespace SecretsGui.AKV
{
    public class AKVBrowserViewModel : VaultBrowserViewModel
    {
        private readonly ISecretStore _store;

        public static async Task<AKVBrowserViewModel> TryConnectAsync(string kvUrl, TokenCredential cred)
        {
            try
            {
                var kvuri = new Uri(kvUrl);
                var secrets = new AKVSecretStore(kvuri, cred);
                var secretsList = await Converter<SecretRef>.ToListAsync(secrets.GetSecretRefsAsync());
                var certs = await Converter<CertRef>.ToListAsync(secrets.GetCertRefsAsync());

                return new AKVBrowserViewModel(kvuri.Host, secrets, secretsList, certs);
            }
            catch (Azure.RequestFailedException ex)
            {
                if (ex.Status == 401)
                {
                    // Sign in failed (Unauthorized)
                    return null;
                }

                throw;
            }
        }

        public AKVBrowserViewModel(string name, ISecretStore store, List<SecretRef> secrets, List<CertRef> certs) : base(secrets, certs)
        {
            _store = store;
            Name = name;
        }

        public override Task<string> GetSecretValue(string name)
        {
            return _store.GetSecretValueAsync(name);
        }

        public override async Task<string> GetCertSubjectName(string name)
        {
            return (await LazyLoadCertificateAsync(name)).SubjectName.Format(false);
        }

        public override async Task<string> GetCertThumbprint(string name)
        {
            return (await LazyLoadCertificateAsync(name)).Thumbprint;
        }

        public override async Task SaveCertPublicKeyToFile(string name, string filename)
        {
            var cert = await LazyLoadCertificateAsync(name);
            await File.WriteAllBytesAsync(filename, cert.RawData);
        }

        public override async Task SaveCertPrivateKeyToFile(string name, string filename)
        {
            var password = PasswordGenerator.GeneratePassword(64);
            var privateKey = await _store.GetPrivateKeyAsync(name, true);
            var bytes = privateKey.Export(X509ContentType.Pfx, password);
            await File.WriteAllBytesAsync(filename, bytes);
            var passwordFile = (filename.EndsWith(".pfx") ? filename.Substring(0, filename.Length - 4) : filename) +
                               ".pw";
            await File.WriteAllTextAsync(passwordFile, password);
        }

        public string Name { get; set; }

        private readonly Dictionary<string, X509Certificate2> _certs = new Dictionary<string, X509Certificate2>();

        private async Task<X509Certificate2> LazyLoadCertificateAsync(string name)
        {
            if (!_certs.ContainsKey(name))
                _certs[name] = await _store.GetCertAsync(name);

            return _certs[name];
        }
    }
}