using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class ServiceCostMap : ClassMap<ServiceCost>
    {
        public ServiceCostMap()
        {
            Table("servicecosts");
            Id(x => x.Id);
            Map(x => x.Description);
            Map(x => x.Cost);
            References(x => x.WorkOrder).Column("WorkOrderId").Not.Nullable();
        }
    }
}