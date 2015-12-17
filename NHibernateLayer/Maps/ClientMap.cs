using FluentNHibernate.Mapping;
using AutoRepair.DataAccess.Entities;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("clients");
            Id(x => x.Id);
            Map(x => x.Nit);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.MobilePhone);
            Map(x => x.Phone);
        }
    }
}
