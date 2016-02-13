using FluentNHibernate.Mapping;
using AutoRepair.DataAccess.Entities;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("users");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.UserName);
            Map(x => x.Type);
            Map(x => x.Hash);
            Map(x => x.Salt);
            Map(x => x.IsActive);
            Map(x => x.IsSystemUser);
            Map(x => x.ProfitPercentage);
        }
    }
}