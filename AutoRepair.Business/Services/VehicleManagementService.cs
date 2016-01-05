using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class VehicleManagementService : IVehicleManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Vehicle> _vehicleRepository;

        public VehicleManagementService(IIntKeyedRepository<DataAccess.Entities.Vehicle> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void Dispose()
        {
            _vehicleRepository.Dispose();
        }


        public IEnumerable<VehicleConsult> GetAllVehicles()
        {
            return _vehicleRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Vehicle, VehicleConsult>);
        }

        public void Add(Vehicle vehicle)
        {
            _vehicleRepository.Add(AutoMapper.Mapper.Map<Vehicle, DataAccess.Entities.Vehicle>(vehicle));
        }

        public void Update(Vehicle vehicle)
        {
            _vehicleRepository.Update(AutoMapper.Mapper.Map<Vehicle, DataAccess.Entities.Vehicle>(vehicle));
        }

        public Vehicle GetVehicle(int vehicleId)
        {
            var client = _vehicleRepository.FindBy(vehicleId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Vehicle, Vehicle>(client);
        }

        public void Delete(Vehicle vehicle)
        {
            _vehicleRepository.Delete(AutoMapper.Mapper.Map<Vehicle, DataAccess.Entities.Vehicle>(vehicle));
        }
    }
}