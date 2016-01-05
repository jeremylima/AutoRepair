namespace AutoRepair.Business.Models
{
    public class Vehicle
    {
        public virtual int Id { get; set; }

        public virtual string LicensePlate { get; set; }
        public virtual VehicleModel Model { get; set; }

        public virtual int Year { get; set; }
        public virtual MotorType MotorType { get; set; }

        public virtual int MotorCc { get; set; }

        public virtual Color Color { get; set; }

        public virtual VehicleType Type { get; set; }
    }

    public class VehicleConsult
    {
        public virtual int Id { get; set; }

        public virtual string LicensePlate { get; set; }

        public virtual string Make { get; set; }

        public virtual string Model { get; set; }

        public virtual int Year { get; set; }

        public virtual string MotorType { get; set; }

        public virtual int MotorCc { get; set; }

        public virtual string Color { get; set; }

        public virtual string Type { get; set; }
    }
}