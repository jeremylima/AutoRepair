using System;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;
using CustomExceptions;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    class frmColor : frmEntityBase
    {

        public Business.Models.Color _entity { get; set; }
        public IColorManagementService _entityManagementService;

        public frmColor(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<IColorManagementService>();
        }

        public override void frmEntityBase_Load(object sender, EventArgs e)
        {
            if (_entity != null)
                txtName.Text = _entity.Name;
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_entity != null)
                {
                    _entity.Name = txtName.Text;
                    _entityManagementService.Update(_entity);
                    Notifier.ShowEditSuccessMessage();
                }
                else
                {
                    _entityManagementService.Add(new Color
                    {
                        Name = txtName.Text
                    });

                    Notifier.ShowAddSuccessMessage();
                }

                Close();
            }
            catch (DuplicatedEntryKeyException)
            {
                Notifier.DuplicatedEntry();
            }
        }
    }
}
