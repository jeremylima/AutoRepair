using System;
using System.Collections.Generic;
using System.Linq;
using AutoRepair.DataAccess.Entities;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;
using User = AutoRepair.Business.Models.User;

namespace AutoRepair.Business.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.User> _userRepository;
        private readonly IEncrypter _encrypter;

        public UserManagementService(IIntKeyedRepository<DataAccess.Entities.User> userRepository, IEncrypter encrypter)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
        }
        
        public void Dispose()
        {
            _userRepository.Dispose();
            _encrypter.Dispose();
        }

        public IEnumerable<User> GetAllActiveUsers()
        {
            return _userRepository.FilterBy(x=>x.IsActive && x.Id>1) .Select(AutoMapper.Mapper.Map<DataAccess.Entities.User, User>);

        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.FilterBy(x => x.Id > 1).Select(AutoMapper.Mapper.Map<DataAccess.Entities.User, User>);
        }

        public void Add(User user)
        {
            var _user = _userRepository.FindBy(x => x.UserName == user.UserName);
            if(_user!=null)
                throw new DuplicatedEntryKeyException();

            _user = AutoMapper.Mapper.Map<User, DataAccess.Entities.User>(user);
            var salt = _encrypter.CreateSalt(10);
            var hash = _encrypter.GenerateSHA256Hash(user.Password, salt);
            _user.Salt = salt;
            _user.Hash = hash;
            _userRepository.Add(_user);

        }

        public void Update(User user)
        {
            var _user = _userRepository.FindBy(x => x.UserName == user.UserName);

            if (_user != null)
            {
                if (_user.Id != user.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _user = _userRepository.FindBy(user.Id);
            _user.Name = user.Name;
            _user.UserName = user.UserName;
            _user.IsActive = user.IsActive;
            _user.IsSystemUser = user.IsSystemUser;
            _user.Type = user.Type;
            _user.ProfitPercentage = user.ProfitPercentage;
           _userRepository.Update(_user);
        }

        public User GetUser(int userId)
        {
            var user = _userRepository.FindBy(userId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.User, User>(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(AutoMapper.Mapper.Map<User, DataAccess.Entities.User>(user));
        }

        public bool ChangePassword(int userId, string newPassword, string oldPassword, UserType userType)
        {
            var user = _userRepository.FindBy(userId);
            string hash;
            if (userType == UserType.Normal)
            {
                hash = _encrypter.GenerateSHA256Hash(oldPassword, user.Salt);
                if (!hash.Equals(user.Hash))
                    return false;
            }

            var salt = _encrypter.CreateSalt(10);
            hash = _encrypter.GenerateSHA256Hash(newPassword, salt);

            user.Hash = hash;
            user.Salt = salt;
            _userRepository.Update(user);

            return true;
        }
    }
}