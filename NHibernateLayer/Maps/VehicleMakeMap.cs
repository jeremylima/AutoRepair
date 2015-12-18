using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class VehicleMakeMap : ClassMap<VehicleMake>
    {
        public VehicleMakeMap()
        {
            Table("vehiclemakes");
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.VehicleModels).KeyColumn("VehicleMakeId").Cascade.All();
        }
    }
}