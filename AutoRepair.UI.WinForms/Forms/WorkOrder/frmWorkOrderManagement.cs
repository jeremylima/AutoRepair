using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.DataAccess.Entities;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using DevExpress.XtraGrid.Views.Grid;

namespace AutoRepair.UI.WinForms.Forms.WorkOrder
{
    public partial class frmWorkOrderManagement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public WorkOrderStatus _workOrderstatus { get; set; }
        public IWorkOrderManagementService _workOrderManagementService;

        public frmWorkOrderManagement()
        {
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();
            InitializeComponent();
        }

        private void LoadWorkOrders()
        {
            var workOrders = _workOrderManagementService.GetAllWorkOrdersConsult();
            gvWorkOrderList.DataSource = workOrders;
            gridView1.BestFitColumns();
        }

        private void LoadWorkOrdersByStatus(WorkOrderStatus workOrderStatus)
        {
            var workOrders = _workOrderManagementService.GetAllWorkOrdersByStatusConsult(workOrderStatus);
            gvWorkOrderList.DataSource = workOrders;
            //gridView1.PopulateColumns();
         
        }

        private void frmWorkOrderManagement_Load(object sender, EventArgs e)
        {
            LoadInitValues();
        }

        private void LoadInitValues()
        {
            radioButtonViewTypeOrders.EditValue = WorkOrderStatus.Open.ToString();
            LoadWorkOrdersByStatus(WorkOrderStatus.Open);
            EnableOptionsByStatus(WorkOrderStatus.Open);

        }

        private void EnableOptionsByStatus(WorkOrderStatus status)
        {
            if (status == WorkOrderStatus.Open)
            {
                btnFinalizeWorkOrder.Enabled = true;
                btnReOpenWorkOrder.Enabled = false;
                btnDeleteWorkOrder.Enabled = true;
                btnEditWorkOrder.Enabled = true;
            }
            else
            {
                btnFinalizeWorkOrder.Enabled = false;
                btnReOpenWorkOrder.Enabled = true;
                btnDeleteWorkOrder.Enabled = false;
                btnEditWorkOrder.Enabled = false;
            }
        }

        private void btnEditWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var workOrderConsult = (Business.Models.WorkOrderConsult)(gvWorkOrderList.FocusedView as GridView).GetRow(rowHandle);

                var frmWorkOrder = new frmWorkOrder { _workOrder = _workOrderManagementService.GetWorkOrder(workOrderConsult.Id) };
                frmWorkOrder.ShowDialog();
                LoadWorkOrdersByStatus(_workOrderstatus);
            }
        }

        private void btnNewWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var workOrder = new frmWorkOrder();
            workOrder.ShowDialog();

            LoadWorkOrdersByStatus(_workOrderstatus);
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
                    LoadWorkOrdersByStatus(_workOrderstatus);
                }
            }
        }

        private void btnFinalizeWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var workOrder = (Business.Models.WorkOrderConsult)(gvWorkOrderList.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowFinalizeWorkOrderMessage(workOrder.Id) == DialogResult.Yes)
                {
                    _workOrderManagementService.Finalize(workOrder.Id);
                    LoadWorkOrdersByStatus(_workOrderstatus);
                }
            }
        }

        private void repositoryRadioButtonViewTypeOrders_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            _workOrderstatus = (WorkOrderStatus) Enum.Parse(typeof (WorkOrderStatus), e.NewValue.ToString(), true);
            LoadWorkOrdersByStatus(_workOrderstatus);
            EnableOptionsByStatus(_workOrderstatus);
        }

        private void btnViewWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var workOrderConsult = (Business.Models.WorkOrderConsult)(gvWorkOrderList.FocusedView as GridView).GetRow(rowHandle);

                var frmWorkOrder = new frmWorkOrder { _workOrder = _workOrderManagementService.GetWorkOrder(workOrderConsult.Id), IsViewAction = true};
                frmWorkOrder.ShowDialog();
                
            }
        }

        private void btnReOpenWorkOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var workOrder = (Business.Models.WorkOrderConsult)(gvWorkOrderList.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowReOpenWorkOrderMessage(workOrder.Id) == DialogResult.Yes)
                {
                    _workOrderManagementService.ReOpen(workOrder.Id);
                    LoadWorkOrdersByStatus(_workOrderstatus);
                }
            }
        }
    }
}
