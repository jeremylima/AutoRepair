using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using AutoRepair.DataAccess.Entities;


namespace AutoRepair.Business.Models
{
    public class User
    {
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public virtual string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public virtual string UserName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public virtual string Password { get; set; }

        [Required]
        public virtual UserType Type { get; set; }
        [Required(ErrorMessage = "El rango es de 0 a 100")]

        public virtual bool IsActive { get; set; }

        public virtual bool IsSystemUser { get; set; }

        [Range(0.0, 1.0)]
        public virtual decimal ProfitPercentage { get; set; }
        
    }
}