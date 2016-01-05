using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class VehicleTypeMap : ClassMap<VehicleType>
    {
        public VehicleTypeMap()
        {
            Table("vehicletypes");
            Id(x => x.Id);
            Map(x => x.Name);
        } 
    }
}