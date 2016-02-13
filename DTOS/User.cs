using System;

namespace AutoRepair.DataAccess.Entities
{
    public enum UserType
    {
        Administrator,
        Normal
    }

    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Hash { get; set; }
        public virtual string Salt { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsSystemUser { get; set; }
        public virtual UserType Type { get; set; }
        public virtual decimal ProfitPercentage { get; set; }
    }
}