using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IVehicleMakeManagementService : IDisposable
    {
        IEnumerable<VehicleMakeConsult> GetAllVehicleMakes();
        void Add(VehicleMake vehicleMake);
        void Update(VehicleMake vehicleMake);
        VehicleMake GetVehicleMake(int vehicleMakeId);
        void Delete(VehicleMake vehicleMake);
    }
}