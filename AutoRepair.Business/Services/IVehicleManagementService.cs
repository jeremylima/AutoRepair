using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IVehicleManagementService : IDisposable
    {
        IEnumerable<VehicleConsult> GetAllVehicles();
        void Add(Vehicle vehicle);
        void Update(Vehicle vehicle);
        Vehicle GetVehicle(int vehicleId);
        VehicleConsult GetVehicleConsult(int vehicleId);
        void Delete(Vehicle vehicle);
    }
}