using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IMakeManagementService : IDisposable
    {
        IEnumerable<Make> GetAllMakes();
        void Add(Make make);
        void Update(Make make);
        Make GetMake(int makeId);
        void Delete(Make make);
    }
}