using Azure.Core;
using Azure.Identity;

namespace SecretsGui
{
    public abstract class AzureConnection
    {
        public abstract string DisplayName { get; }
        public override string ToString() => DisplayName;

        public abstract TokenCredential GetCredential();

        public class SavedConnection : AzureConnection
        {
            private readonly TokenCredential _credential;

            public SavedConnection(TokenCredential credential, string displayName)
            {
                _credential = credential;
                DisplayName = displayName;
            }

            public override string DisplayName { get; }

            public override TokenCredential GetCredential()
            {
                return _credential;
            }
        }

        public class OpenInBrowser : AzureConnection
        {
            public override string DisplayName => "Sign in with my browser";

            public override TokenCredential GetCredential()
            {
                return new InteractiveBrowserCredential();
            }
        }

        public class UseDefaultCredential : AzureConnection
        {
            public override string DisplayName => "Use AzureDefaultCredential";

            public override TokenCredential GetCredential()
            {
                return new DefaultAzureCredential();
            }
        }

        public class CreateNewConnection : AzureConnection
        {
            public override string DisplayName => "(New saved connection...)";

            public override TokenCredential GetCredential()
            {
                return null;
            }
        }
    }
}
