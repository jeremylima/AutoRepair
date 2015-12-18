namespace AutoRepair.DataAccess.Entities
{
    public class VehicleModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }
    }
}