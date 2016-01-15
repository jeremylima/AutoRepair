using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepair.UI.WinForms.Commons
{
    public class ConstantModel
    {
        public dynamic Name { get; set; }
    }

    public class Utils
    {
        public static IEnumerable<ConstantModel> GetRangeOfYears()
        {
            var years = Enumerable.Range(1900, DateTime.Now.Year - 1900 + 1).ToList().OrderByDescending(x => x);

            return years.Select(year => new ConstantModel
            {
                Name = year
            }).ToList();
        }

        public static IEnumerable<ConstantModel> GetWorkOrderStatus()
        {
            return new List<ConstantModel> {new ConstantModel {Name = "Abierta"}, new ConstantModel {Name = "Cerrada"}};
        }
    }
}