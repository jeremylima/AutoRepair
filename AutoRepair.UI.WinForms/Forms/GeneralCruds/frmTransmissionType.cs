using System;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;
using CustomExceptions;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    public class frmTransmissionType : frmEntityBase
    {
        public Business.Models.TransmissionType _entity { get; set; }
        public ITransmissionTypeManagementService _entityManagementService;

        public frmTransmissionType(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<ITransmissionTypeManagementService>();
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
                    _entityManagementService.Add(new TransmissionType
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