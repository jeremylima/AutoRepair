using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class VehicleMap : ClassMap<Vehicle>
    {
        public VehicleMap()
        {
            Table("vehicles");
            Id(x => x.Id);
            Map(x => x.LicensePlate);
            Map(x => x.Year);
            Map(x => x.MotorCc);
            References(x => x.Model).Column("ModelId").Not.Nullable();
            References(x => x.MotorType).Column("MotorTypeId").Not.Nullable();
            References(x => x.Color).Column("ColorId").Not.Nullable();
            References(x => x.Type).Column("VehicleTypeId").Not.Nullable();
            References(x => x.TransmissionType).Column("TransmissionTypeId").Not.Nullable();
        }
    }
}