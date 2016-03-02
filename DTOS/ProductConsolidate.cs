using System.Collections;

namespace AutoRepair.DataAccess.Entities
{
    public class ProductConsolidate
    {
        public virtual Product Product { get; set; }
        public virtual decimal TotalQuantity { get; set; }
        public virtual decimal TotalCost { get; set; }
        public virtual decimal TotalProfit { get; set; }
    }
}