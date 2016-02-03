using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using DevExpress.XtraGrid.Views.Grid;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    public class frmVehicleMakeManagement : frmEntityManagementBase
    {
        public IVehicleMakeManagementService _entityManagementService;
        public frmVehicleMakeManagement(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<IVehicleMakeManagementService>();
        }

        public override void frmEntityManagementBase_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void LoadEntities()
        {
            var entityList = _entityManagementService.GetAllVehicleMakes();
            gvEntities.DataSource = entityList;
        }

        public override void btnNewEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var entity = new frmVehicleMake(FormName.VehicleMake);
            entity.ShowDialog();

            LoadEntities();
        }

        public override void btnEditEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = viewEntities.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var entity = (Business.Models.VehicleMakeConsult)(gvEntities.FocusedView as GridView).GetRow(rowHandle);

                var frmEntity = new frmVehicleMake(FormName.VehicleMake) { _entity = _entityManagementService.GetVehicleMake(entity.Id) };
                frmEntity.ShowDialog();
                LoadEntities();
            }
        }

        public override void btnDeleteEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = viewEntities.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var entity = (Business.Models.VehicleMakeConsult)(gvEntities.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _entityManagementService.Delete(_entityManagementService.GetVehicleMake(entity.Id));
                    LoadEntities();
                }
            }

        }
    }
}