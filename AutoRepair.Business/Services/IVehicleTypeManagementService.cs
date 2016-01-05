using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IVehicleTypeManagementService : IDisposable
    {
        IEnumerable<VehicleType> GetAllVehicleTypes();
        void Add(VehicleType vehicleType);
        void Update(VehicleType vehicleType);
        VehicleType GetVehicleType(int vehicleTypeId);
        void Delete(VehicleType vehicleType);
    }
}