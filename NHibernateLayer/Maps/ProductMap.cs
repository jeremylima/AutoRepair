using AutoRepair.DataAccess.Entities;
using FluentNHibernate.Mapping;

namespace AutoRepair.DataAccess.NHibernate.Maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("products");
            Id(x=>x.Id);
            Map(x => x.Code);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.Stock);
            Map(x => x.CostPrice);
            Map(x => x.SalePrice);
            References(x => x.Category).Column("CategoryId").Not.Nullable();
            References(x => x.Make).Column("MakeId").Not.Nullable();
        }
    }
}