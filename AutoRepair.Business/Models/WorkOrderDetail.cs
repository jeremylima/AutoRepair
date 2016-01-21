namespace AutoRepair.Business.Models
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

    public class WorkOrderDetailConsult
    {
        public virtual int Id { get; set; }
        public virtual string Product { get; set; }
        public virtual decimal CostPrice { get; set; }
        public virtual decimal SalePrice { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual decimal Total => SalePrice*Quantity;
    }
}