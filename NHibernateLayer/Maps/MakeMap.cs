using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class MakeMap : ClassMap<Make>
    {
        public MakeMap()
        {
            Table("makes");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}