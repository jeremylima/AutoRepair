using System;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.CrudBase;

namespace AutoRepair.UI.WinForms.Forms.GeneralCruds
{
    public class frmVehicleMake : frmEntityBase
    {
        public Business.Models.VehicleMake _entity { get; set; }
        public IVehicleMakeManagementService _entityManagementService;

        public frmVehicleMake(string formTitle) : base(formTitle)
        {
            _entityManagementService = CompositionRoot.Resolve<IVehicleMakeManagementService>();
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
                _entityManagementService.Add(new Business.Models.VehicleMake
                {
                    Name = txtName.Text
                });

                Notifier.ShowAddSuccessMessage();
            }

            Close();
        }
    }
}