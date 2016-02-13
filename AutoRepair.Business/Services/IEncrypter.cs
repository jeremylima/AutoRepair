using System;

namespace AutoRepair.Business.Services
{
    public interface IEncrypter : IDisposable
    {
        string CreateSalt(int size);
        string GenerateSHA256Hash(string input, string salt);
    }
}