using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;

namespace AutoRepair.UI.WinForms.Forms.Vehicle
{
    public partial class frmVehicleHistory : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.Vehicle _vehicle { get; set; }
        public IWorkOrderManagementService _workOrderManagementService;

        public frmVehicleHistory()
        {
            InitializeComponent();
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();
        }

        private void frmVehicleHistory_Load(object sender, EventArgs e)
        {
            LoadVehicle(AutoMapper.Mapper.Map<Business.Models.Vehicle, VehicleConsult>(_vehicle));
            LoadVehicleHistory(_vehicle.Id);
        }

        private void LoadVehicleHistory(int vehicleId)
        {
            var history = _workOrderManagementService.GetAllWorkOrdersByVehicle(vehicleId);
            gvWorkOrders.DataSource = history;


        }

        private void LoadVehicle(Business.Models.VehicleConsult vehicle)
        {
            if (vehicle != null)
            {
                gvVehicle.DataSource = new List<VehicleConsult> { vehicle };
            }
        }

        private void btnExpandAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viewWorkOrders.BeginUpdate();
            try
            {
                var dataRowCount = viewWorkOrders.DataRowCount;
                for (var rHandle = 0; rHandle < dataRowCount; rHandle++)
                    viewWorkOrders.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                viewWorkOrders.EndUpdate();
            }
        }

        private void btnCollapseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viewWorkOrders.BeginUpdate();
            try
            {
                var dataRowCount = viewWorkOrders.DataRowCount;
                for (var rHandle = 0; rHandle < dataRowCount; rHandle++)
                    viewWorkOrders.SetMasterRowExpanded(rHandle, false);
            }
            finally
            {
                viewWorkOrders.EndUpdate();
            }
        }
    }
}
