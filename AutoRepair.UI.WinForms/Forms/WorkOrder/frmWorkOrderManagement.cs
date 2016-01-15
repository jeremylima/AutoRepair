using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using DevExpress.XtraGrid.Views.Grid;

namespace AutoRepair.UI.WinForms.Forms.WorkOrder
{
    public partial class frmWorkOrderManagement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IWorkOrderManagementService _workOrderManagementService;

        public frmWorkOrderManagement()
        {
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();
            InitializeComponent();
        }

        private void LoadWorkOrders()
        {
            var workOrders = _workOrderManagementService.GetAllWorkOrders();
            gvWorkOrderList.DataSource = workOrders;
        }

        private void frmWorkOrderManagement_Load(object sender, EventArgs e)
        {
            LoadWorkOrders();
        }

        private void btnEditWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var workOrderConsult = (Business.Models.WorkOrderConsult)(gvWorkOrderList.FocusedView as GridView).GetRow(rowHandle);

                var frmWorkOrder = new frmWorkOrder { _workOrder = _workOrderManagementService.GetWorkOrder(workOrderConsult.Id) };
                frmWorkOrder.ShowDialog();
                LoadWorkOrders();
            }
        }

        private void btnNewWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var workOrder = new frmWorkOrder();
            workOrder.ShowDialog();

            LoadWorkOrders();
        }

        private void btnDeleteWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var workOrder = (Business.Models.WorkOrderConsult)(gvWorkOrderList.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _workOrderManagementService .Delete(_workOrderManagementService.GetWorkOrder(workOrder.Id));
                    LoadWorkOrders();
                }
            }
        }
    }
}
