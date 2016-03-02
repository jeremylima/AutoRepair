using System.Collections.Generic;
using AutoRepair.DataAccess.Entities;

namespace AutoRepair.Business.Models
{
    public class GrossProfitReportDto
    {
        public IList<ProductConsolidate> ProductsConsolidates { get; set; }
        public IList<ServiceConsolidate> ServicesConsolidates { get; set; }
    }


    
}