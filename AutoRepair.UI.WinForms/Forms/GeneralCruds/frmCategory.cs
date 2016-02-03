using System;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    public class frmCategory : frmEntityBase
    {
        public Business.Models.Category _entity { get; set; }
        public ICategoryManagementService _entityManagementService;

        public frmCategory(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<ICategoryManagementService>();
        }

        public override void frmEntityBase_Load(object sender, EventArgs e)
        {
            if (_entity != null)
                txtName.Text = _entity.Name;
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_entity != null)
            {
                _entity.Name = txtName.Text;
                _entityManagementService.Update(_entity);
                Notifier.ShowEditSuccessMessage();
            }
            else
            {
                _entityManagementService.Add(new Business.Models.Category
                {
                    Name = txtName.Text
                });

                Notifier.ShowAddSuccessMessage();
            }

            Close();
        }
    }
}