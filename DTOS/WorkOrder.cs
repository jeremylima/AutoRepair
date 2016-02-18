using System;
using System.Collections.Generic;

namespace AutoRepair.DataAccess.Entities
{
    public enum WorkOrderStatus
    {
        Open,
        Finalized
    }

    public class WorkOrder
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual WorkOrderStatus Status { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual DateTime? FinalizedDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual User User { get; set; }
        public virtual IList<WorkOrderDetail> WorkOrderDetails { get; set; }
        public virtual IList<ServiceCost> ServiceCosts { get; set; }

    }
}