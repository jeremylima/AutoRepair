using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IClientManagementService : IDisposable
    {
        IEnumerable<Client> GetAllClients();
        void Add(Client client);
        void Update(Client client);
        Client GetClient(int clientId);
        void Delete(Client client);
    }
}