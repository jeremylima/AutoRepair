using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using DevExpress.XtraGrid.Views.Grid;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;
using AutoRepair.UI.WinForms.Forms.VehicleModel;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    public class frmVehicleModelManagement : frmEntityManagementBase
    {

        public IVehicleModelManagementService _entityManagementService;
        public frmVehicleModelManagement(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<IVehicleModelManagementService>();
        }

        public override void frmEntityManagementBase_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void LoadEntities()
        {
            var entityList = _entityManagementService.GetAllVehicleModels();
            gvEntities.DataSource = entityList;
            viewEntities.Columns[3].Visible = false;

        }

        public override void btnNewEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var entity = new frmVehicleModel();
            entity.ShowDialog();

            LoadEntities();
        }

        public override void btnEditEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = viewEntities.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var entity = (Business.Models.VehicleModelConsult)(gvEntities.FocusedView as GridView).GetRow(rowHandle);

                var frmEntity = new frmVehicleModel { _vehicleModelConsult = entity };
                frmEntity.ShowDialog();
                LoadEntities();
            }
        }

        public override void btnDeleteEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = viewEntities.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var entity = (Business.Models.VehicleModelConsult)(gvEntities.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _entityManagementService.Delete(_entityManagementService.GetVehicleModel(entity.Id));
                    LoadEntities();
                }
            }

        }


    }
}