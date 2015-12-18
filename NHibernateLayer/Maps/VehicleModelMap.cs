using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class VehicleModelMap : ClassMap<VehicleModel>
    {
        public VehicleModelMap()
        {
            Table("vehiclemodels");
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.VehicleMake).Column("VehicleMakeId");
        }
         
    }
}