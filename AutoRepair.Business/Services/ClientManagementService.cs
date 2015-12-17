using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class ClientManagementService : IClientManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Client> _customerRepository;

        public ClientManagementService(IIntKeyedRepository<DataAccess.Entities.Client> customerRepository)
        {
            _customerRepository = customerRepository;

        }

        public void Dispose()
        {
            _customerRepository.Dispose();
        }

        public IEnumerable<Client> GetAllClients()
        {
             return _customerRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Client, Client>);
            
        }

        public void Add(Client client)
        {
            _customerRepository.Add(AutoMapper.Mapper.Map<Client, DataAccess.Entities.Client>(client));
           
        }

        public void Update(Client client)
        {
            _customerRepository.Update(AutoMapper.Mapper.Map<Client, DataAccess.Entities.Client>(client));
        }

        public Client GetClient(int clientId)
        {
            var client = _customerRepository.FindBy(clientId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Client, Client>(client);
        }

        public void Delete(Client client)
        {
            _customerRepository.Delete(AutoMapper.Mapper.Map<Client, DataAccess.Entities.Client>(client));
        }
    }
}