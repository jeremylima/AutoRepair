using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class ColorMap : ClassMap<Color>
    {
        public ColorMap()
        {
            Table("colors");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}