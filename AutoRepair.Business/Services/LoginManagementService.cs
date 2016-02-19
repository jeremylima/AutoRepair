using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;
using Security.Encryption;

namespace AutoRepair.Business.Services
{
    public class LoginManagementService : ILoginManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.User> _userRepository;
        private readonly IEncrypter _encrypter;

        public LoginManagementService(IIntKeyedRepository<DataAccess.Entities.User> userRepository, IEncrypter encrypter)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }

        public User Login(string username, string password)
        {
            var user = _userRepository.FindBy(x => x.UserName == username);
            if (user == null)
                throw new LoginFailureException(); 

            if (!user.IsSystemUser)
                throw new LoginFailureException();

            var hash = _encrypter.GenerateSHA256Hash(password, user.Salt);

            if (user.Hash.Equals(hash))
                return AutoMapper.Mapper.Map<DataAccess.Entities.User, User>(user);

            throw new LoginFailureException();
        }
    }
}