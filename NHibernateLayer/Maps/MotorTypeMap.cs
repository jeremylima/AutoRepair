using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class MotorTypeMap : ClassMap<MotorType>
    {
        public MotorTypeMap()
        {
            Table("motortypes");
            Id(x => x.Id);
            Map(x => x.Name);
        } 
    }
}