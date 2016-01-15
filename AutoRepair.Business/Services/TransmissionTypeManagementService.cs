using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class TransmissionTypeManagementService : ITransmissionTypeManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.TransmissionType> _transmissionTypeRepository;

        public TransmissionTypeManagementService(IIntKeyedRepository<DataAccess.Entities.TransmissionType> transmissionTypeRepository)
        {
            _transmissionTypeRepository = transmissionTypeRepository;

        }

        public void Dispose()
        {
            _transmissionTypeRepository.Dispose();
        }

        public IEnumerable<TransmissionType> GetAllTransmissionTypes()
        {
            return _transmissionTypeRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.TransmissionType, TransmissionType>);
        }

        public void Add(TransmissionType transmissionType)
        {
            _transmissionTypeRepository.Add(AutoMapper.Mapper.Map<TransmissionType, DataAccess.Entities.TransmissionType>(transmissionType));
        }

        public void Update(TransmissionType transmissionType)
        {
            _transmissionTypeRepository.Update(AutoMapper.Mapper.Map<TransmissionType, DataAccess.Entities.TransmissionType>(transmissionType));
        }

        public TransmissionType GetTransmissionType(int transmissionTypeId)
        {
            var transmissionType = _transmissionTypeRepository.FindBy(transmissionTypeId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.TransmissionType, TransmissionType>(transmissionType);
        }

        public void Delete(TransmissionType transmissionType)
        {
            _transmissionTypeRepository.Delete(AutoMapper.Mapper.Map<TransmissionType, DataAccess.Entities.TransmissionType>(transmissionType));
        }
    }
}