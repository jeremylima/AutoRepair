using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using DevExpress.XtraGrid.Views.Grid;
using AutoRepair.UI.WinForms.Commons;

namespace AutoRepair.UI.WinForms.Forms.Vehicle
{
    public partial class frmVehicleManagement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IVehicleManagementService _vehicleManagementService;

        public frmVehicleManagement()
        {
            _vehicleManagementService = CompositionRoot.Resolve<IVehicleManagementService>();
            InitializeComponent();
        }

        private void LoadVehicles()
        {
            var vehicleList = _vehicleManagementService.GetAllVehicles();
            gvVehicleList.DataSource = vehicleList;
        }

        private void frmVehicleManagement_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void btnNewVehicle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var vehicle = new frmVehicle();
            vehicle.ShowDialog();

            LoadVehicles();
        }

        private void btnEditVehicle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var vehicle = (Business.Models.VehicleConsult)(gvVehicleList.FocusedView as GridView).GetRow(rowHandle);

                var frmProduct = new frmVehicle { _vehicle = _vehicleManagementService.GetVehicle(vehicle.Id) };
                frmProduct.ShowDialog();
                LoadVehicles();
            }
        }

        private void btnDeleteVehicle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var vehicle = (Business.Models.VehicleConsult)(gvVehicleList.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _vehicleManagementService.Delete(_vehicleManagementService.GetVehicle(vehicle.Id));
                    LoadVehicles();
                }
            }
        }
    }
}
