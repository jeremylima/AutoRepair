using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

namespace AutoRepair.Business.Services
{
    public class VehicleMakeManagementService : IVehicleMakeManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.VehicleMake> _vehicleMakeRepository;

        public VehicleMakeManagementService(IIntKeyedRepository<DataAccess.Entities.VehicleMake> vehicleMakeRepository)
        {
            _vehicleMakeRepository = vehicleMakeRepository;

        }

        public void Dispose()
        {
            _vehicleMakeRepository.Dispose();
        }

        public IEnumerable<VehicleMakeConsult> GetAllVehicleMakes()
        {
            return _vehicleMakeRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.VehicleMake, VehicleMakeConsult>);
        }

        public void Add(VehicleMake vehicleMake)
        {
            var _vehicleMake = _vehicleMakeRepository.FindBy(x => x.Name == vehicleMake.Name);
            if (_vehicleMake != null)
                throw new DuplicatedEntryKeyException();

            _vehicleMakeRepository.Add(AutoMapper.Mapper.Map<VehicleMake, DataAccess.Entities.VehicleMake>(vehicleMake));
        }

        public void Update(VehicleMake vehicleMake)
        {
            var _vehicleMake = _vehicleMakeRepository.FindBy(x => x.Name == vehicleMake.Name);
            if (_vehicleMake != null)
            {
                if (_vehicleMake.Id != vehicleMake.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _vehicleMakeRepository.Update(AutoMapper.Mapper.Map<VehicleMake, DataAccess.Entities.VehicleMake>(vehicleMake));
        }

        public VehicleMake GetVehicleMake(int vehicleMakeId)
        {
            var vehicleMake = _vehicleMakeRepository.FindBy(vehicleMakeId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.VehicleMake, VehicleMake>(vehicleMake);
        }

        public void Delete(VehicleMake vehicleMake)
        {
            _vehicleMakeRepository.Delete(AutoMapper.Mapper.Map<VehicleMake, DataAccess.Entities.VehicleMake>(vehicleMake));
        }
    }
}