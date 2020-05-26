using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretsGui.Models
{
    public abstract class VaultBrowserViewModel
    {
        protected VaultBrowserViewModel(List<SecretRef> secrets, List<CertRef> certs)
        {
            Secrets = secrets;
            Certs = certs;
        }

        public List<SecretRef> Secrets { get; }

        public List<CertRef> Certs { get; }

        public abstract Task<string> GetSecretValue(string name);
        public abstract Task<string> GetCertSubjectName(string name);
        public abstract Task<string> GetCertThumbprint(string name);
        public abstract Task SaveCertPublicKeyToFile(string name, string filename);
        public abstract Task SaveCertPrivateKeyToFile(string name, string filename);
    }
}