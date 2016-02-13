using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class WorkOrderMap : ClassMap<WorkOrder>
    {
        public WorkOrderMap()
        {
            Table("workorders");
            Id(x => x.Id);
            Map(x => x.Description);
            Map(x => x.Date);
            Map(x => x.Status);
            References(x => x.Client).Column("ClientId").Not.Nullable();
            References(x => x.Vehicle).Column("VehicleId").Not.Nullable();
            References(x => x.User).Column("UserId").Not.Nullable();
            HasMany(x => x.ServiceCosts).KeyColumn("WorkOrderId").Cascade.All();
            HasMany(x => x.WorkOrderDetails).KeyColumn("WorkOrderId").Cascade.All();
        }
         
    }
}