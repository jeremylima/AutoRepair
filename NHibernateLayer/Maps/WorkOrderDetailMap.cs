using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class WorkOrderDetailMap : ClassMap<WorkOrderDetail>
    {
        public WorkOrderDetailMap()
        {
            Table("workorderdetails");
            Id(x => x.Id);
            Map(x => x.CostPrice);
            Map(x => x.SalePrice);
            Map(x => x.Quantity);
            References(x => x.Product).Column("ProductId").Not.Nullable();
            References(x => x.WorkOrder).Column("WorkOrderId").Not.Nullable();
        }
    }
}