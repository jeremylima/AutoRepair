namespace AutoRepair.Business.Models
{
    public class ServiceCost
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}