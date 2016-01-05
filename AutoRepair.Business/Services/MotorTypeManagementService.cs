using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class MotorTypeManagementService : IMotorTypeManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.MotorType> _motorTypeRepository;

        public MotorTypeManagementService(IIntKeyedRepository<DataAccess.Entities.MotorType> motorTypeRepository)
        {
            _motorTypeRepository = motorTypeRepository;

        }

        public void Dispose()
        {
            _motorTypeRepository.Dispose();
        }

        public IEnumerable<MotorType> GetAllMotorTypes()
        {
            return _motorTypeRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.MotorType, MotorType>);
        }

        public void Add(MotorType motorType)
        {
            _motorTypeRepository.Add(AutoMapper.Mapper.Map<MotorType, DataAccess.Entities.MotorType>(motorType));
        }

        public void Update(MotorType motorType)
        {
            _motorTypeRepository.Update(AutoMapper.Mapper.Map<MotorType, DataAccess.Entities.MotorType>(motorType));
        }

        public MotorType GetMotorType(int motorTypeId)
        {
            var motorType = _motorTypeRepository.FindBy(motorTypeId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.MotorType, MotorType>(motorType);
        }

        public void Delete(MotorType motorType)
        {
            _motorTypeRepository.Delete(AutoMapper.Mapper.Map<MotorType, DataAccess.Entities.MotorType>(motorType));
        }
    }
}