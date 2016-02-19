using System;

namespace Security.Encryption
{
    public interface IEncrypter : IDisposable
    {
        string CreateSalt(int size);
        string GenerateSHA256Hash(string input, string salt);
    }
}