using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.Security.KeyVault.Certificates;
using Azure.Security.KeyVault.Secrets;
using SecretsGui.Models;

namespace SecretsGui.AKV
{
    public class AKVSecretStore : ISecretStore
    {
        private readonly Uri _kvUri;
        private readonly TokenCredential _cred;

        public AKVSecretStore(Uri kvUri, TokenCredential cred = null)
        {
            _kvUri = kvUri;
            _cred = cred ?? new DefaultAzureCredential();
        }

        public async IAsyncEnumerable<SecretRef> GetSecretRefsAsync()
        {
            var client = new SecretClient(_kvUri, _cred);
            var secrets = client.GetPropertiesOfSecretsAsync();

            await foreach (var secret in secrets)
            {
                yield return new SecretRef {Name = secret.Name};
            }
        }

        public async IAsyncEnumerable<CertRef> GetCertRefsAsync()
        {
            var client = new CertificateClient(_kvUri, _cred);
            var certs = client.GetPropertiesOfCertificatesAsync();

            await foreach (var cert in certs)
            {
                yield return new CertRef { Name = cert.Name };
            }
        }

        public async Task<string> GetSecretValueAsync(string name)
        {
            var client = new SecretClient(_kvUri, _cred);
            return (await client.GetSecretAsync(name)).Value.Value;
        }

        public async Task<X509Certificate2> GetCertAsync(string name)
        {
            var client = new CertificateClient(_kvUri, _cred);
            return new X509Certificate2((await client.GetCertificateAsync(name)).Value.Cer);
        }

        public async Task<X509Certificate2> GetPrivateKeyAsync(string name, bool exportable)
        {
            var privateKey = await GetSecretValueAsync(name);
            return new X509Certificate2(Convert.FromBase64String(privateKey), (string)null, exportable? X509KeyStorageFlags.Exportable: 0);
        }
    }
}
