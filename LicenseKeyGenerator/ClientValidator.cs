using System;
using System.Linq;
using System.Management;
using Security.Encryption;


namespace LicenseKeyGenerator
{
    public class ClientValidator : IClientValidator
    {
        private readonly IEncrypter _encrypter;
        public string GenerateKey()
        {
            return _encrypter.CreateSalt(10);
        }

        public ClientValidator(IEncrypter encrypter)
        {
            _encrypter = encrypter;
        }

        public bool RegisterKey(string key)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateKey(string key)
        {
            throw new System.NotImplementedException();
        }

        private string GetSerialNumberFromProcessor()
        {
            var searcher =
                  new ManagementObjectSearcher("root\\CIMV2",
                  "SELECT * FROM Win32_Processor");

            string serialNumber = null;

            foreach (var queryObj in searcher.Get())
            {
                serialNumber = queryObj["ProcessorId"].ToString();
            }

            return serialNumber ?? string.Empty;
        }

        private string GetVersionFromBIOS()
        {
            var searcher =
                  new ManagementObjectSearcher("root\\CIMV2",
                  "SELECT * FROM Win32_BIOS");

            string version = null;

            foreach (var queryObj in searcher.Get())
            {
                version = queryObj["Version"].ToString();
            }

            return version ?? string.Empty;
        }
    }
}