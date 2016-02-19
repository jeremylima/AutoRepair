using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

namespace AutoRepair.Business.Services
{
    public class ClientManagementService : IClientManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Client> _clientRepository;

        public ClientManagementService(IIntKeyedRepository<DataAccess.Entities.Client> clientRepository)
        {
            _clientRepository = clientRepository;

        }

        public void Dispose()
        {
            _clientRepository.Dispose();
        }

        public IEnumerable<Client> GetAllClients()
        {
             return _clientRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Client, Client>);
            
        }

        public void Add(Client client)
        {
            var _client = _clientRepository.FindBy(x => x.Nit == client.Nit);
            if (_client != null)
                throw new DuplicatedEntryKeyException();

            _clientRepository.Add(AutoMapper.Mapper.Map<Client, DataAccess.Entities.Client>(client));
           
        }

        public void Update(Client client)
        {
            var _client = _clientRepository.FindBy(x => x.Nit == client.Nit);
            if (_client != null)
            {
                if (_client.Id != client.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _clientRepository.Update(AutoMapper.Mapper.Map<Client, DataAccess.Entities.Client>(client));
        }

        public Client GetClient(int clientId)
        {
            var client = _clientRepository.FindBy(clientId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Client, Client>(client);
        }

        public void Delete(Client client)
        {
            _clientRepository.Delete(AutoMapper.Mapper.Map<Client, DataAccess.Entities.Client>(client));
        }
    }
}