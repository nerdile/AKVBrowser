using System;
using System.Security.Cryptography;

namespace NerdileSnippets
{
    public static class PasswordGenerator
    {
        public static string GeneratePassword(int length)
        {
            var random = new RNGCryptoServiceProvider();
            var data = new byte[length];
            random.GetNonZeroBytes(data);
            return Convert.ToBase64String(data).Substring(0, length);
        }
    }
}
