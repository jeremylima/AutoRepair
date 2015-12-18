using System.Collections.Generic;

namespace AutoRepair.DataAccess.Entities
{
    public class VehicleMake
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<VehicleModel> VehicleModels { get; set; }
    }
}