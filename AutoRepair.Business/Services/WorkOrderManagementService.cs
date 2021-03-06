﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Entities;
using AutoRepair.DataAccess.Infrastructure;
using Product = AutoRepair.DataAccess.Entities.Product;
using ServiceCost = AutoRepair.DataAccess.Entities.ServiceCost;
using WorkOrder = AutoRepair.Business.Models.WorkOrder;
using WorkOrderDetail = AutoRepair.DataAccess.Entities.WorkOrderDetail;

namespace AutoRepair.Business.Services
{
    public class WorkOrderManagementService : IWorkOrderManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.WorkOrder> _workOrderRepository;
        private readonly IIntKeyedRepository<ServiceCost> _serviceCostRepository;
        private readonly IIntKeyedRepository<WorkOrderDetail> _workOrderDetailsRepository;
        private readonly IIntKeyedRepository<Product> _productRepository;

        public WorkOrderManagementService(IIntKeyedRepository<DataAccess.Entities.WorkOrder> workOrderRepository, IIntKeyedRepository<ServiceCost> serviceCostRepository, IIntKeyedRepository<WorkOrderDetail> workOrderDetailsRepository, IIntKeyedRepository<Product> productRepository)
        {
            _workOrderRepository = workOrderRepository;
            _serviceCostRepository = serviceCostRepository;
            _workOrderDetailsRepository = workOrderDetailsRepository;
            _productRepository = productRepository;
        }

        public void Dispose()
        {
            _workOrderRepository.Dispose();
            _serviceCostRepository.Dispose();
            _workOrderDetailsRepository.Dispose();
            _productRepository.Dispose();
        }


        public IEnumerable<WorkOrder> GetAllWorkOrders()
        {
            return _workOrderRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrder>);
        }

        public IEnumerable<WorkOrderConsult> GetAllWorkOrdersConsult()
        {
            return _workOrderRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrderConsult>);
        }

        public IEnumerable<WorkOrderConsult> GetAllWorkOrdersByStatusConsult(WorkOrderStatus workOrderStatus)
        {
            return _workOrderRepository.FilterBy(x => x.Status == workOrderStatus).Select(AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrderConsult>); 
        }

        public IEnumerable<WorkOrder> GetAllWorkOrdersByStatusBetweenDatesPerUser(WorkOrderStatus workOrderStatus, DateTime initDate,
            DateTime endDate, int userId)
        {
            return _workOrderRepository.FilterBy(x => x.Status == workOrderStatus && x.FinalizedDate.Value>=initDate.Date && x.FinalizedDate.Value<=endDate.Date && x.User.Id == userId).Select(AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrder>);
        }

        public void Add(WorkOrder workOrder, bool finalized = false)
        {
            var _workOrderMap = AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder);
            var workOrderIdCreated = _workOrderRepository.AddAndReturnIdCreated(new DataAccess.Entities.WorkOrder
            {
                Client = _workOrderMap.Client,
                Date = _workOrderMap.Date,
                Description = _workOrderMap.Description,
                Status = _workOrderMap.Status,
                Vehicle = _workOrderMap.Vehicle,
                User = _workOrderMap.User
            });

            var _workOrder = _workOrderRepository.FindBy(workOrderIdCreated);

            _workOrder.ServiceCosts = _workOrderMap.ServiceCosts.Select(serviceCost => new ServiceCost
            {
                WorkOrder = _workOrder,
                Description = serviceCost.Description,
                Cost = serviceCost.Cost
            }).ToList();

            _workOrder.WorkOrderDetails = _workOrderMap.WorkOrderDetails.Select(workOrderDetail => new WorkOrderDetail
            {
                WorkOrder = _workOrder,
                Product = workOrderDetail.Product,
                CostPrice = workOrderDetail.CostPrice,
                SalePrice = workOrderDetail.SalePrice,
                Quantity = workOrderDetail.Quantity

            }).ToList();

            _workOrderRepository.Update(_workOrder);

            if (finalized)
                Finalize(AutoMapper.Mapper.Map<DataAccess.Entities.WorkOrder, WorkOrder>(_workOrder));
        }

        public void Update(WorkOrder workOrder, bool finalized = false)
        {
            var serviceCosts = _serviceCostRepository.FilterBy(x => x.WorkOrder == AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));
            var workOrderDetails = _workOrderDetailsRepository.FilterBy(x => x.WorkOrder == AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));

            _serviceCostRepository.Delete(serviceCosts);
            _workOrderDetailsRepository.Delete(workOrderDetails);

            _workOrderRepository.Update(AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));

            if(finalized)
                Finalize(workOrder);

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

        public void Finalize(int workOrderId)
        {
            var workOrder = _workOrderRepository.FindBy(workOrderId);
            FinalizeWorkOrder(workOrder);

        }

        public void ReOpen(int workOrderId)
        {
            var workOrder = _workOrderRepository.FindBy(workOrderId);

            workOrder.Status = WorkOrderStatus.Open;
            workOrder.FinalizedDate = null;
            _workOrderRepository.Update(workOrder);

            var products = new List<Product>();
            foreach (var workOrderDetail in workOrder.WorkOrderDetails)
            {
                var product = workOrderDetail.Product;
                product.Stock += workOrderDetail.Quantity;
                products.Add(product);
            }

            _productRepository.Update(products);

        }

        public BindingList<VehicleHistory> GetAllWorkOrdersByVehicle(int vehicleId)
        {
           var workOrders =  _workOrderRepository.FilterBy(x => x.Vehicle.Id == vehicleId && x.Status == WorkOrderStatus.Finalized);
            var vehicleHistory = new BindingList<VehicleHistory>();

            foreach (var workOrder in workOrders)
            {
                var serviceCosts =
                    AutoMapper.Mapper.Map<IList<DataAccess.Entities.ServiceCost>, IList<Models.ServiceCost>>(
                        workOrder.ServiceCosts);

                var details =
                    AutoMapper.Mapper.Map<IList<DataAccess.Entities.WorkOrderDetail>, IList<WorkOrderDetailConsult>>(
                        workOrder.WorkOrderDetails);

                vehicleHistory.Add(new VehicleHistory
                {
                    Date = workOrder.Date,
                    Description = workOrder.Description,
                    OrderId = workOrder.Id,
                    UserName = workOrder.User.Name,
                    WorkOrderDetails = new BindingList<WorkOrderDetailConsult>(details),
                    ServiceCosts =  new BindingList<Models.ServiceCost>(serviceCosts)
                });
            }

            return vehicleHistory;
        }

        public void Finalize(WorkOrder workOrder)
        {
            FinalizeWorkOrder(AutoMapper.Mapper.Map<WorkOrder, DataAccess.Entities.WorkOrder>(workOrder));
        }

        private void FinalizeWorkOrder(DataAccess.Entities.WorkOrder workOrder)
        {
            workOrder.Status = WorkOrderStatus.Finalized;
            workOrder.FinalizedDate = DateTime.Now.Date;
            _workOrderRepository.Update(workOrder);

            var products = new List<Product>();
            foreach (var workOrderDetail in workOrder.WorkOrderDetails)
            {
                var product = workOrderDetail.Product;
                product.Stock -= workOrderDetail.Quantity;
                products.Add(product);
            }

            _productRepository.Update(products);
        }
    }
}