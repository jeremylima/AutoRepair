using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Entities;
using WorkOrder = AutoRepair.Business.Models.WorkOrder;

namespace AutoRepair.Business.Services
{
    public interface IWorkOrderManagementService : IDisposable
    {
        IEnumerable<WorkOrderConsult> GetAllWorkOrders();
        IEnumerable<WorkOrderConsult> GetAllWorkOrdersByStatus(WorkOrderStatus workOrderStatus);
        void Add(WorkOrder workOrder, bool finalized = false);
        void Update(WorkOrder workOrder, bool finalized = false);
        WorkOrder GetWorkOrder(int workOrderId);
        void Delete(WorkOrder workOrder);
        void Finalize(int workOrderId);
        void ReOpen(int idworkOrderId);
    }
}