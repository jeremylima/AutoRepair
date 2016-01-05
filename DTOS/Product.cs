namespace AutoRepair.DataAccess.Entities
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Stock { get; set; }
        public virtual decimal CostPrice { get; set; }
        public virtual decimal SalePrice { get; set; }
        public virtual Category Category { get; set; }
        public virtual Make Make { get; set; }

    }
}