using System;
using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Entities;
using AutoRepair.DataAccess.Infrastructure;
using ServiceCost = AutoRepair.DataAccess.Entities.ServiceCost;
using WorkOrder = AutoRepair.DataAccess.Entities.WorkOrder;

namespace AutoRepair.Business.Services
{
    public class ReportManagementService : IReportManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.WorkOrder> _workOrderRepository;

        public ReportManagementService(IIntKeyedRepository<WorkOrder> workOrderRepository)
        {
            _workOrderRepository = workOrderRepository;
        }

        public void Dispose()
        {
            _workOrderRepository.Dispose();
        }

        public IList<GrossProfitReportDto> GetGrossProfitData(DateTime initDate, DateTime endDate)
        {
            var workOrders =
                _workOrderRepository.FilterBy(
                    x =>
                        x.Status == WorkOrderStatus.Finalized && x.FinalizedDate.Value >= initDate.Date &&
                        x.FinalizedDate.Value <= endDate.Date).ToList();

            return new List<GrossProfitReportDto>
            {
                new GrossProfitReportDto
                {
                     ProductsConsolidates = GetProductsConsolidates(workOrders),
                ServicesConsolidates = GetServicesConsolidates(workOrders)
                }
            };
                
        }

        private static IList<ServiceConsolidate> GetServicesConsolidates(List<WorkOrder> workOrders)
        {
            var servicesCost = new List<ServiceCost>();

            var services = workOrders.Select(x => x.ServiceCosts);
            foreach (var service in services)
            {
                servicesCost.AddRange(service);
            }

            var serviceConsolidates = from s in servicesCost
                group s by s.WorkOrder.User
                into g
                let totalCost = g.Sum(x => x.Cost)
                let user = g.Key
                let payEmployee = totalCost*user.ProfitPercentage
                select new ServiceConsolidate
                {
                    User = g.Key,
                    TotalCost = totalCost,
                    PayToEmployee = payEmployee,
                    TotalProfit = totalCost - payEmployee
                };

            return serviceConsolidates.ToList();
            
        }

        private static IList<ProductConsolidate> GetProductsConsolidates(List<WorkOrder> workOrders)
        {
            var productsConsolidates = new List<ProductConsolidate>();
            foreach (var details in workOrders.Select(x => x.WorkOrderDetails))
            {
                foreach (var workOrderDetail in details)
                {
                    var productsConsolidate = productsConsolidates.FirstOrDefault(x => x.Product == workOrderDetail.Product);

                    if (productsConsolidate != null)
                    {
                        productsConsolidate.TotalCost += workOrderDetail.Quantity*workOrderDetail.CostPrice;
                        productsConsolidate.TotalQuantity += workOrderDetail.Quantity;
                        productsConsolidate.TotalProfit += workOrderDetail.Quantity*workOrderDetail.SalePrice -
                                                           workOrderDetail.Quantity*workOrderDetail.CostPrice;
                    }
                    else
                    {
                        productsConsolidates.Add(new ProductConsolidate
                        {
                            Product = workOrderDetail.Product,
                            TotalCost = workOrderDetail.Quantity*workOrderDetail.CostPrice,
                            TotalQuantity = workOrderDetail.Quantity,
                            TotalProfit =
                                workOrderDetail.Quantity*workOrderDetail.SalePrice -
                                workOrderDetail.Quantity*workOrderDetail.CostPrice
                        });
                    }
                }
            }
            return productsConsolidates;
        }
    }
   
}