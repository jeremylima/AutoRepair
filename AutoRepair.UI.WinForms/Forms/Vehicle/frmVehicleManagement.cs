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
    }
}
