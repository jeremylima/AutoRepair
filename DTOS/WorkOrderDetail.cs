using System.Collections.Generic;

namespace AutoRepair.DataAccess.Entities
{
    public class WorkOrderDetail
    {
        public virtual int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual decimal CostPrice { get; set; }
        public virtual decimal SalePrice { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}