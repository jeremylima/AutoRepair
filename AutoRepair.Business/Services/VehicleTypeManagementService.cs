using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class VehicleTypeManagementService : IVehicleTypeManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.VehicleType> _vehicleTypeRepository;

        public VehicleTypeManagementService(IIntKeyedRepository<DataAccess.Entities.VehicleType> vehicleTypeRepository)
        {
            _vehicleTypeRepository = vehicleTypeRepository;

        }

        public void Dispose()
        {
            _vehicleTypeRepository.Dispose();
        }

        public IEnumerable<VehicleType> GetAllVehicleTypes()
        {
            return _vehicleTypeRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.VehicleType, VehicleType>);
        }

        public void Add(VehicleType vehicleType)
        {
            _vehicleTypeRepository.Add(AutoMapper.Mapper.Map<VehicleType, DataAccess.Entities.VehicleType>(vehicleType));
        }

        public void Update(VehicleType vehicleType)
        {
            _vehicleTypeRepository.Update(AutoMapper.Mapper.Map<VehicleType, DataAccess.Entities.VehicleType>(vehicleType));
        }

        public VehicleType GetVehicleType(int vehicleTypeId)
        {
            var vehicleType = _vehicleTypeRepository.FindBy(vehicleTypeId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.VehicleType, VehicleType>(vehicleType);
        }

        public void Delete(VehicleType vehicleType)
        {
            _vehicleTypeRepository.Delete(AutoMapper.Mapper.Map<VehicleType, DataAccess.Entities.VehicleType>(vehicleType));
        }
    }
}