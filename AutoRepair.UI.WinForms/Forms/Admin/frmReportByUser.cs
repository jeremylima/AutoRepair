using System;
using System.Linq;
using AutoRepair.Business.Services;
using AutoRepair.DataAccess.Entities;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.Reports;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;

namespace AutoRepair.UI.WinForms.Forms.Admin
{
    public enum ReportType
    {
        Users,
        GrossProfit
    }

    public partial class frmReportByUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IUserManagementService _userManagementService;
        public IWorkOrderManagementService _workOrderManagementService;
        public IReportManagementService _reportManagementService;
        public ReportType ReportType { get; set; }

        public frmReportByUser()
        {
            InitializeComponent();
            _userManagementService = CompositionRoot.Resolve<IUserManagementService>();
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();
            _reportManagementService = CompositionRoot.Resolve<IReportManagementService>();
        }

        private void btnViewReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var initDate = (DateTime)dateEditInitDate.EditValue;
            var endDate = (DateTime)dateEditEndDate.EditValue;

            switch (ReportType)
            {
                case ReportType.Users:
                {
                
                    var user = _userManagementService.GetUser((int) cmbUser.EditValue);

                    var dataSource =
                        _workOrderManagementService.GetAllWorkOrdersByStatusBetweenDatesPerUser(WorkOrderStatus.Finalized,
                            initDate, endDate, user.Id);

                    var rpt = new WorkOrderByUserReport {DataSource = dataSource};

                    rpt.Parameters["UserName"].Value = cmbUser.Text;
                    rpt.Parameters["InitDate"].Value = initDate;
                    rpt.Parameters["EndDate"].Value = endDate;
                    rpt.Parameters["Percentage"].Value = user.ProfitPercentage;

                    rpt.CreateDocument();
                    rpt.ShowRibbonPreviewDialog();
                }
                    break;
                case ReportType.GrossProfit:
                {
                    var dataSource = _reportManagementService.GetGrossProfitData(initDate, endDate);

                    var rpt = new WorkOrdersGrossProfitReport {DataSource = dataSource};

                    rpt.Parameters["InitDate"].Value = initDate;
                    rpt.Parameters["EndDate"].Value = endDate;

                    rpt.CreateDocument();
                    rpt.ShowRibbonPreviewDialog();
                }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void frmReportByUser_Load(object sender, EventArgs e)
        {
            if (ReportType == ReportType.GrossProfit)
            {
                Text = "Reporte de Utilidades";
                itemUsersLookupEdit.Visibility = LayoutVisibility.Never;
            }

            LoadUser();
            dateEditInitDate.EditValue = DateTime.Now;
            dateEditEndDate.EditValue = DateTime.Now;
        }

        private void LoadUser(int userSelected = 0)
        {
            var users = _userManagementService.GetAllUsers().Select(models => new {models.Id, models.Name});
            ComponentFiller.FillLookUpEdit(cmbUser).Data(users, "Name", "Id", userSelected);
        }
    }
}
