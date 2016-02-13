using System;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface ILoginManagementService : IDisposable
    {
        User Login(string username, string password);
    }
}