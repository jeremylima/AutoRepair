using System;
using System.Linq;
using AutoRepair.Business.Services;
using AutoRepair.DataAccess.Entities;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.Reports;
using DevExpress.XtraReports.UI;

namespace AutoRepair.UI.WinForms.Forms.Admin
{
    public partial class frmReportByUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IUserManagementService _userManagementService;
        public IWorkOrderManagementService _workOrderManagementService;
        

        public frmReportByUser()
        {
            InitializeComponent();
            _userManagementService = CompositionRoot.Resolve<IUserManagementService>();
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();
        }

        private void btnViewReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var initDate = (DateTime)dateEditInitDate.EditValue;
            var endDate = (DateTime)dateEditEndDate.EditValue;
            var user = _userManagementService.GetUser((int) cmbUser.EditValue);

            var dataSource = _workOrderManagementService.GetAllWorkOrdersByStatusBetweenDatesPerUser(WorkOrderStatus.Finalized, initDate, endDate, user.Id);

            var rpt = new WorkOrderByUserReport();
            rpt.DataSource = dataSource;

            rpt.Parameters["UserName"].Value = cmbUser.Text;
            rpt.Parameters["InitDate"].Value = initDate;
            rpt.Parameters["EndDate"].Value = endDate;
            rpt.Parameters["Percentage"].Value = user.ProfitPercentage;
            
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void frmReportByUser_Load(object sender, EventArgs e)
        {
            LoadUser();
            dateEditInitDate.EditValue = DateTime.Now;
            dateEditEndDate.EditValue = DateTime.Now;
        }

        private void LoadUser(int userSelected = 0)
        {
            var users = _userManagementService.GetAllUsers().Select(models => new { models.Id, models.Name });
            ComponentFiller.FillLookUpEdit(cmbUser).Data(users, "Name", "Id", userSelected);
        }
    }
}
