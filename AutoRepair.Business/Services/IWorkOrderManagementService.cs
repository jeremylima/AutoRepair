using System;
using System.Collections.Generic;
using System.ComponentModel;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Entities;
using User = AutoRepair.Business.Models.User;
using WorkOrder = AutoRepair.Business.Models.WorkOrder;

namespace AutoRepair.Business.Services
{
    public interface IWorkOrderManagementService : IDisposable
    {
        IEnumerable<WorkOrder> GetAllWorkOrders();
        IEnumerable<WorkOrderConsult> GetAllWorkOrdersConsult();
        IEnumerable<WorkOrderConsult> GetAllWorkOrdersByStatusConsult(WorkOrderStatus workOrderStatus);
        IEnumerable<WorkOrder> GetAllWorkOrdersByStatusBetweenDatesPerUser(WorkOrderStatus workOrderStatus, DateTime initDate, DateTime endDate, int userId);
        void Add(WorkOrder workOrder, bool finalized = false);
        void Update(WorkOrder workOrder, bool finalized = false);
        WorkOrder GetWorkOrder(int workOrderId);
        void Delete(WorkOrder workOrder);
        void Finalize(int workOrderId);
        void ReOpen(int idworkOrderId);
        BindingList<VehicleHistory> GetAllWorkOrdersByVehicle(int vehicleId);
    }
}