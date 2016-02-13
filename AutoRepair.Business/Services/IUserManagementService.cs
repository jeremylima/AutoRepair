using System;
using System.Collections.Generic;
using AutoRepair.DataAccess.Entities;
using User = AutoRepair.Business.Models.User;

namespace AutoRepair.Business.Services
{
    public interface IUserManagementService : IDisposable
    {
        IEnumerable<User> GetAllActiveUsers();
        IEnumerable<User> GetAllUsers();
        void Add(User user);
        void Update(User user);
        User GetUser(int userId);
        void Delete(User user);
        bool ChangePassword(int userId, string newPassword, string oldPassword, UserType userType);
    }
}