using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.Business.Services
{
    public class WorkOrderManagementService : IWorkOrderManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.WorkOrder> _workOrderRepository;
        private readonly IIntKeyedRepository<DataAccess.Entities.ServiceCost> _serviceCostRepository;

        public WorkOrderManagementService(IIntKeyedRepository<DataAccess.Entities.WorkOrder> workOrderRepository, IIntKeyedRepository<DataAccess.Entities.ServiceCost> serviceCostRepository)
        {
            _workOrderRepository = workOrderRepository;
            _serviceCostRepository = serviceCostRepository;
        }

        public void Dispose()
        {
            _workOrderRepository.Dispose();
            _serviceCostRepository.Dispose();
        }


        public IEnumerable<WorkOrderConsult> GetAllWorkOrders() { 
            return _workOrderRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrderConsult>);
        }

        public void Add(WorkOrder workOrder)
        {
            _workOrderRepository.Add(AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));
        }

        public void Update(WorkOrder workOrder)
        {
            var serviceCosts = _serviceCostRepository.FilterBy(x => x.WorkOrder == AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));

            foreach (var serviceCost in serviceCosts)
            {
                _serviceCostRepository.Delete(serviceCost);
                
            }

            _workOrderRepository.Update(AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));
        }

        public WorkOrder GetWorkOrder(int workOrderId)
        {
            var workOrder = _workOrderRepository.FindBy(workOrderId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrder>(workOrder);
        }

        public void Delete(WorkOrder workOrder)
        {
            _workOrderRepository.Delete(AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));
        }
    }
}