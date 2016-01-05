using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IMotorTypeManagementService : IDisposable
    {
        IEnumerable<MotorType> GetAllMotorTypes();
        void Add(MotorType motorType);
        void Update(MotorType motorType);
        MotorType GetMotorType(int motorTypeId);
        void Delete(MotorType motorType);
    }
}