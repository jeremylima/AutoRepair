using System;

namespace Security.Encryption
{
    public class Encrypter : IEncrypter
    {
        public string CreateSalt(int size)
        {

            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public string GenerateSHA256Hash(string input, string salt)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            var sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            var hash = sha256hashstring.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}