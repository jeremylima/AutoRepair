using System;

namespace AutoRepair.DataAccess.Entities
{
    public class ServiceCost
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}