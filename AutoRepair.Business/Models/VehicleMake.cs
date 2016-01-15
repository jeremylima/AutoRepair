using System.Collections.Generic;

namespace AutoRepair.Business.Models
{
    public class VehicleMake
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<VehicleModel>  VehicleModels { get; set; }
    }

    public class VehicleMakeConsult
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}