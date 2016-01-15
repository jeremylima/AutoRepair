using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IWorkOrderManagementService : IDisposable
    {
        IEnumerable<WorkOrderConsult> GetAllWorkOrders();
        void Add(WorkOrder workOrder);
        void Update(WorkOrder workOrder);
        WorkOrder GetWorkOrder(int workOrderId);
        void Delete(WorkOrder workOrder);
    }
}