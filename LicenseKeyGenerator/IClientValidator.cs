using System.Security.Policy;

namespace LicenseKeyGenerator
{
    public interface IClientValidator
    {
        string GenerateKey();
        bool RegisterKey(string key);
        bool ValidateKey(string key);

    }
}