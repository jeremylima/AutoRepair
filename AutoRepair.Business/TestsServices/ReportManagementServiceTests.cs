using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using AutoRepair.Business.Services;
using AutoRepair.DataAccess.Entities;
using AutoRepair.DataAccess.NHibernate;
using NHibernate;
using Xunit;

namespace AutoRepair.Business.TestsServices
{
    public class ReportManagementServiceTests
    {
        public ISessionFactory SessionFactory { get; set; }
        public IReportManagementService ReportManagementService { get; set; }
        public ReportManagementServiceTests()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AutoRepairDb"].ConnectionString;
            SessionFactory = new NHibernateHelper(connectionString).SessionFactory;
            ReportManagementService = new ReportManagementService(new Repository<WorkOrder>(SessionFactory));
        }
        [Fact]
        public void CanGetData()
        {
            var repo = ReportManagementService.GetGrossProfitData(DateTime.Now.AddYears(-1), DateTime.Now);


        }
    }
}