using System;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;
using CustomExceptions;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    public class frmMotorType : frmEntityBase
    {
        public Business.Models.MotorType _entity { get; set; }
        public IMotorTypeManagementService _entityManagementService;

        public frmMotorType(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<IMotorTypeManagementService>();
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
                    _entityManagementService.Add(new MotorType
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