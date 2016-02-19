using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

namespace AutoRepair.Business.Services
{
    public class VehicleModelManagementService : IVehicleModelManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.VehicleModel> _vehicleModelRepository;

        public VehicleModelManagementService(IIntKeyedRepository<DataAccess.Entities.VehicleModel> vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;

        }

        public void Dispose()
        {
            _vehicleModelRepository.Dispose();
        }

        public IEnumerable<VehicleModelConsult> GetAllVehicleModels()
        {
            return _vehicleModelRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.VehicleModel, VehicleModelConsult>);
        }

        public IEnumerable<VehicleModel> GetVehicleModelsByMake(int makeId)
        {
            return _vehicleModelRepository.FilterBy(x=>x.VehicleMake.Id == makeId).Select(AutoMapper.Mapper.Map<DataAccess.Entities.VehicleModel, VehicleModel>);
        }

        public int GetVehicleMakeIdByVehicleModelId(int modelId)
        {
            var vehicleModel = _vehicleModelRepository.FindBy(x => x.Id == modelId);
            return vehicleModel.VehicleMake.Id;
        }

        public void Add(VehicleModel vehicleModel)
        {
            var _vehicleModel = _vehicleModelRepository.FindBy(x => x.Name == vehicleModel.Name && x.VehicleMake.Id == vehicleModel.VehicleMake.Id);
            if (_vehicleModel != null)
                throw new DuplicatedEntryKeyException();

            _vehicleModelRepository.Add(AutoMapper.Mapper.Map<VehicleModel, DataAccess.Entities.VehicleModel>(vehicleModel));
        }

        public void Update(VehicleModel vehicleModel)
        {
            var _vehicleModel = _vehicleModelRepository.FindBy(x => x.Name == vehicleModel.Name && x.VehicleMake.Id == vehicleModel.VehicleMake.Id);
            if (_vehicleModel != null)
            {
                if (_vehicleModel.Id != vehicleModel.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _vehicleModelRepository.Update(AutoMapper.Mapper.Map<VehicleModel, DataAccess.Entities.VehicleModel>(vehicleModel));
        }

        public VehicleModel GetVehicleModel(int vehicleModelId)
        {
            var vehicleModel = _vehicleModelRepository.FindBy(vehicleModelId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.VehicleModel, VehicleModel>(vehicleModel);
        }

        public void Delete(VehicleModel vehicleModel)
        {
            _vehicleModelRepository.Delete(AutoMapper.Mapper.Map<VehicleModel, DataAccess.Entities.VehicleModel>(vehicleModel));
        }
    }
}