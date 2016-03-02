using System;
using System.Linq;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;
using DevExpress.XtraGrid.Views.Grid;

namespace AutoRepair.UI.WinForms.Forms.User
{
    public class frmUserManagement : frmEntityManagementBase
    {
        public IUserManagementService _entityManagementService;
        public frmUserManagement(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<IUserManagementService>();
            
        }

        public override void frmEntityManagementBase_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void LoadEntities()
        {
            var entityList = _entityManagementService.GetAllUsers();
            gvEntities.DataSource = entityList;

            if (entityList.Any())
            {
                var passwordColumn = viewEntities.Columns.ColumnByFieldName("Password");
                passwordColumn.Visible = false;
            }
                
        }

        public override void btnNewEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var entity = new frmUser();
            entity.ShowDialog();

            LoadEntities();
        }

        public override void btnEditEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = viewEntities.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var entity = (Business.Models.User)(gvEntities.FocusedView as GridView).GetRow(rowHandle);

                var frmEntity = new frmUser{ _user = _entityManagementService.GetUser(entity.Id) };
                frmEntity.ShowDialog();
                LoadEntities();
            }
        }

        public override void btnDeleteEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = viewEntities.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var entity = (Business.Models.User)(gvEntities.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _entityManagementService.Delete(_entityManagementService.GetUser(entity.Id));
                    LoadEntities();
                }
            }

        }
    }
}