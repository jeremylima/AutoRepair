using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class MakeManagementService : IMakeManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Make> _makeRepository;

        public MakeManagementService(IIntKeyedRepository<DataAccess.Entities.Make> makeRepository)
        {
            _makeRepository = makeRepository;

        }

        public void Dispose()
        {
            _makeRepository.Dispose();
        }

        public IEnumerable<Make> GetAllMakes()
        {
            return _makeRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Make, Make>);
        }

        public void Add(Make make)
        {
            _makeRepository.Add(AutoMapper.Mapper.Map<Make, DataAccess.Entities.Make>(make));
        }

        public void Update(Make make)
        {
            _makeRepository.Update(AutoMapper.Mapper.Map<Make, DataAccess.Entities.Make>(make));
        }

        public Make GetMake(int makeId)
        {
            var make = _makeRepository.FindBy(makeId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Make, Make>(make);
        }

        public void Delete(Make make)
        {
            _makeRepository.Delete(AutoMapper.Mapper.Map<Make, DataAccess.Entities.Make>(make));
        }
    }
}