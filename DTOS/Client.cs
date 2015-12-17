namespace AutoRepair.DataAccess.Entities
{
    public class Client
    {
        public virtual int Id { get; set; }
        public virtual string Nit { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string MobilePhone { get; set; }
    }
}