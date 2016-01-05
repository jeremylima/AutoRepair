using System;

namespace AutoRepair.DataAccess.Entities
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
}