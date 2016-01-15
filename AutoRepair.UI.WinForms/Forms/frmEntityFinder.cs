using System;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using DevExpress.XtraGrid.Views.Grid;

namespace AutoRepair.UI.WinForms.Forms
{
    public partial class frmEntityFinder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Type Entity { get; set; }
        public int IdSelected { get; set; }
        public IClientManagementService _clientManagementService;
        public IVehicleManagementService _vehicleManagementService;

        public frmEntityFinder()
        {
            _clientManagementService = CompositionRoot.Resolve<IClientManagementService>();
            _vehicleManagementService = CompositionRoot.Resolve<IVehicleManagementService>();
            InitializeComponent();
        }

        private void frmEntityFinder_Load(object sender, EventArgs e)
        {
            GetDataSource();
        }

        private void GetDataSource()
        {
            if (Entity == typeof (Business.Models.Client))
                gvEntityList.DataSource = _clientManagementService.GetAllClients();

            if (Entity == typeof(Business.Models.VehicleConsult))
                gvEntityList.DataSource = _vehicleManagementService.GetAllVehicles() ;
            
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetIdValue();
        }

        private void GetIdValue()
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                dynamic entitySelected = (gvEntityList.FocusedView as GridView).GetRow(rowHandle);
                IdSelected = entitySelected.Id;
            }
            Close();
        }

        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {
            GetIdValue();
        }
    }
}
