using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface ITransmissionTypeManagementService : IDisposable
    {
        IEnumerable<TransmissionType> GetAllTransmissionTypes();
        void Add(TransmissionType transmissionType);
        void Update(TransmissionType transmissionType);
        TransmissionType GetTransmissionType(int transmissionTypeId);
        void Delete(TransmissionType transmissionType);
    }
}