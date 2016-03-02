namespace AutoRepair.DataAccess.Entities
{
    public class ServiceConsolidate
    {
        public virtual User User { get; set; }
        public virtual decimal TotalCost { get; set; }
        public virtual decimal PayToEmployee { get; set; }
        public virtual decimal TotalProfit { get; set; }
    }
}