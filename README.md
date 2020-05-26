# AKVBrowser

A GUI for browsing Azure Key Vaults.

## Prerequisites

* You'll need the [.net core 3.1 desktop runtime](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Sharing secrets with Azure Key Vault

1. Create an Azure Key Vault in your organization.
2. Grant full access to the secrets to yourself and the person you are sending them to.
3. Put the secrets that you want to transfer into the vault.
4. Create an appSettings.json file to configure the defaults for the app:

       { keyVaultUrl: "https://my-vault-name-goes-here.vault.azure.net/" }

5. Send the recipient the AKVBrowser.exe, appSettings.json, and the link to the [.net core 3.1 desktop runtime](https://dotnet.microsoft.com/download/dotnet-core/3.1). 
6. Now, they can run AKVBrowser to sign in and access the secrets in the Vault.

