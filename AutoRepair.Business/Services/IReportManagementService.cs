using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IReportManagementService : IDisposable
    {
        IList<GrossProfitReportDto> GetGrossProfitData(DateTime initDate, DateTime endDate);
    }
}