using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IVehicleModelManagementService : IDisposable
    {
        IEnumerable<VehicleModelConsult> GetAllVehicleModels();
        IEnumerable<VehicleModel> GetVehicleModelsByMake(int makeId);
        int GetVehicleMakeIdByVehicleModelId(int modelId);
        void Add(VehicleModel vehicleModel);
        void Update(VehicleModel vehicleModel);
        VehicleModel GetVehicleModel(int vehicleModelId);
        void Delete(VehicleModel vehicleModel);
    }
}