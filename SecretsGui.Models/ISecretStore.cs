using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SecretsGui.Models
{
    public interface ISecretStore
    {
        IAsyncEnumerable<SecretRef> GetSecretRefsAsync();

        IAsyncEnumerable<CertRef> GetCertRefsAsync();

        Task<string> GetSecretValueAsync(string name);
        Task<X509Certificate2> GetCertAsync(string name);
        Task<X509Certificate2> GetPrivateKeyAsync(string name, bool exportable = false);
    }
}