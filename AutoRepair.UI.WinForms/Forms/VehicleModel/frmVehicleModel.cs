using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using CustomExceptions;

namespace AutoRepair.UI.WinForms.Forms.VehicleModel
{
    public partial class frmVehicleModel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.VehicleModelConsult _vehicleModelConsult { get; set; }
        public IVehicleMakeManagementService _vehicleMakeManagementService;
        public IVehicleModelManagementService _vehicleModelManagementService;

        public frmVehicleModel()
        {
            _vehicleMakeManagementService = CompositionRoot.Resolve<IVehicleMakeManagementService>();
            _vehicleModelManagementService = CompositionRoot.Resolve<IVehicleModelManagementService>();
            InitializeComponent();
        }

        private void frmVehicleModel_Load(object sender, EventArgs e)
        {
            if (_vehicleModelConsult != null)
            {
                LoadMakes(_vehicleModelConsult.VehicleMakeId);
                txtModel.Text = _vehicleModelConsult.Name;
            }
            else
            {
                LoadMakes();
            }
        }

        private void LoadMakes(int vehicleMakeSelected = 0)
        {
            var vehicleMakes = _vehicleMakeManagementService.GetAllVehicleMakes();
            ComponentFiller.FillLookUpEdit(cmbMake).Data(vehicleMakes, "Name", "Id", vehicleMakeSelected);

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_vehicleModelConsult != null)
                {
                    var _vehicleModel = _vehicleModelManagementService.GetVehicleModel(_vehicleModelConsult.Id);

                    _vehicleModel.Name = txtModel.Text;
                    _vehicleModel.VehicleMake = _vehicleMakeManagementService.GetVehicleMake((int) cmbMake.EditValue);

                    _vehicleModelManagementService.Update(_vehicleModel);

                    Notifier.ShowEditSuccessMessage();
                }
                else
                {
                    _vehicleModelManagementService.Add(new Business.Models.VehicleModel
                    {
                        Name = txtModel.Text,
                        VehicleMake = _vehicleMakeManagementService.GetVehicleMake((int) cmbMake.EditValue)
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
