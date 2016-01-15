using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class TransmissionTypeMap : ClassMap<TransmissionType>
    {
        public TransmissionTypeMap()
        {
            Table("transmissiontypes");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}