using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AutoRepair.Business.Models
{
    public class WorkOrderByUser
    {
        public virtual User User { get; set; }
        public virtual DateTime InitialDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual BindingList<WorkOrderByUserDetailsConsult> WorkOrders { get; set; }
    }
}