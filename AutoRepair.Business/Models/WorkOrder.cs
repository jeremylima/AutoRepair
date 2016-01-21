using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AutoRepair.Business.Models
{
    public class WorkOrder
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Client Client { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual IList<WorkOrderDetail> WorkOrderDetails { get; set; }
        public virtual IList<ServiceCost> ServiceCosts { get; set; }
        
    }

    public class WorkOrderConsult
    {
        public virtual int Id { get; set; }
        public virtual string FullClientName { get; set; }
        public virtual string VehicleDescription { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Status { get; set; }

        /*public virtual IList<WorkOrderDetail> WorkOrderDetails { get; set; }
        public virtual IList<ServiceCost> ServiceCosts { get; set; }*/

    }

    public class WorkOrderBinding
    {
       public virtual BindingList<WorkOrderDetailConsult> WorkOrderDetails { get; set; }
        public virtual BindingList<ServiceCost> ServiceCosts { get; set; }

        public virtual decimal Total
        {
            get
            {
                return WorkOrderDetails.Sum(workOrderDetail => workOrderDetail.SalePrice * workOrderDetail.Quantity) + ServiceCosts.Sum(serviceCost => serviceCost.Cost);
            }
        }
    }

}