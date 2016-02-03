namespace AutoRepair.Business.Models
{
    public class VehicleModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }
    }

    public class VehicleModelConsult
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string VehicleMake { get; set; }
        public virtual int VehicleMakeId { get; set; }
    }
}