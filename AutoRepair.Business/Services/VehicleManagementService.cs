using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

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
            var _vehicle = _vehicleRepository.FindBy(x => x.LicensePlate == vehicle.LicensePlate);
            if (_vehicle != null)
                throw new DuplicatedEntryKeyException();

            _vehicleRepository.Add(AutoMapper.Mapper.Map<Vehicle, DataAccess.Entities.Vehicle>(vehicle));
        }

        public void Update(Vehicle vehicle)
        {
            var _vehicle = _vehicleRepository.FindBy(x => x.LicensePlate == vehicle.LicensePlate);
            if (_vehicle != null)
            {
                if (_vehicle.Id != vehicle.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _vehicleRepository.Update(AutoMapper.Mapper.Map<Vehicle, DataAccess.Entities.Vehicle>(vehicle));
        }

        public Vehicle GetVehicle(int vehicleId)
        {
            var vehicle = _vehicleRepository.FindBy(vehicleId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Vehicle, Vehicle>(vehicle);
        }

        public VehicleConsult GetVehicleConsult(int vehicleId)
        {
            var vehicle = _vehicleRepository.FindBy(vehicleId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Vehicle, VehicleConsult>(vehicle);
        }

        public void Delete(Vehicle vehicle)
        {
            _vehicleRepository.Delete(AutoMapper.Mapper.Map<Vehicle, DataAccess.Entities.Vehicle>(vehicle));
        }
    }
}