using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;

namespace AutoRepair.UI.WinForms.Forms.Vehicle
{
    public partial class frmVehicle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.Vehicle _vehicle { get; set; }
        public IVehicleManagementService _vehicleManagementService;
        public IVehicleTypeManagementService _vehicleTypeManagementService;
        public IColorManagementService _colorManagementService;
        public IMotorTypeManagementService _motorTypeManagementService;
        public IVehicleMakeManagementService _vehicleMakeManagementService;
        public IVehicleModelManagementService _vehicleModelManagementService;
        public ITransmissionTypeManagementService _transmissionTypeManagementService;

        public frmVehicle()
        {
            _vehicleManagementService = CompositionRoot.Resolve<IVehicleManagementService>();
            _vehicleTypeManagementService = CompositionRoot.Resolve<IVehicleTypeManagementService>();
            _colorManagementService = CompositionRoot.Resolve<IColorManagementService>();
            _motorTypeManagementService = CompositionRoot.Resolve<IMotorTypeManagementService>();
            _vehicleMakeManagementService = CompositionRoot.Resolve<IVehicleMakeManagementService>();
            _vehicleModelManagementService = CompositionRoot.Resolve<IVehicleModelManagementService>();
            _transmissionTypeManagementService = CompositionRoot.Resolve<ITransmissionTypeManagementService>();

            InitializeComponent();
        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {
            if (_vehicle != null)
            {
                LoadVehicleTypes(_vehicle.Type.Id);
                LoadColors(_vehicle.Color.Id);
                LoadMotorTypes(_vehicle.MotorType.Id);
                LoadYears(_vehicle.Year);
                LoadMakes(_vehicleModelManagementService.GetVehicleMakeIdByVehicleModelId(_vehicle.Model.Id));
                LoadModels(_vehicle.Model.Id);
                LoadTransmissionTypes(_vehicle.TransmissionType.Id);

                txtLicencePlate.Text = _vehicle.LicensePlate;
                txtMotorCc.Text = _vehicle.MotorCc.ToString();
                
            }
            else
            {
                LoadVehicleTypes();
                LoadColors();
                LoadMotorTypes();
                LoadYears();
                LoadMakes();
                LoadTransmissionTypes();
            }
        }

        private void LoadMakes(int vehicleMakeSelected = 0)
        {
            var vehicleMakes = _vehicleMakeManagementService.GetAllVehicleMakes();
            ComponentFiller.FillLookUpEdit(cmbMake).Data(vehicleMakes, "Name", "Id", vehicleMakeSelected);

        }

        private void LoadModels(int vehicleModelSelected = 0)
        {
            var vehicleModelsByMakeId = _vehicleModelManagementService.GetVehicleModelsByMake((int) cmbMake.EditValue).Select(models=>new {models.Id, models.Name});
            ComponentFiller.FillLookUpEdit(cmbModel).Data(vehicleModelsByMakeId, "Name", "Id", vehicleModelSelected);

        }

        private void LoadYears(int yearSelected = 0)
        {
            var years = Utils.GetRangeOfYears(); 
            ComponentFiller.FillLookUpEdit(cmbYear).Data(years, "Name", "Name", yearSelected);

        }

        private void LoadMotorTypes(int motorTypeSelected = 0)
        {
            var motorTypes = _motorTypeManagementService.GetAllMotorTypes();
            ComponentFiller.FillLookUpEdit(cmbMotorType).Data(motorTypes, "Name", "Id", motorTypeSelected);
        }

        private void LoadColors(int colorSelected = 0)
        {
            var colors = _colorManagementService.GetAllColors();
            ComponentFiller.FillLookUpEdit(cmbColor).Data(colors, "Name", "Id", colorSelected);
        }

        private void LoadVehicleTypes(int vehicleTypeSelected = 0)
        {
            var vehicleTypes = _vehicleTypeManagementService.GetAllVehicleTypes();
            ComponentFiller.FillLookUpEdit(cmbType).Data(vehicleTypes, "Name", "Id", vehicleTypeSelected);
        }

        private void LoadTransmissionTypes(int transmissionTypeSelected = 0)
        {
            var transmissionType = _transmissionTypeManagementService.GetAllTransmissionTypes();
            ComponentFiller.FillLookUpEdit(cmbTransmissionType).Data(transmissionType, "Name", "Id", transmissionTypeSelected);

        }

        private void frmVehicle_Activated(object sender, EventArgs e)
        {
            cmbMake.EditValueChanged += cmbMake_EditValueChanged;
        }

        private void cmbMake_EditValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(() => { cmbModel.EditValue = null; }));
        }

        private void cmbModel_Enter(object sender, EventArgs e)
        {
            if (cmbMake.EditValue == null)
            {
                cmbModel.Properties.DataSource = null;
            }
            else
            {
                LoadModels();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_vehicle != null)
            {
                _vehicle.LicensePlate = txtLicencePlate.Text;
                _vehicle.Model = _vehicleModelManagementService.GetVehicleModel((int) cmbModel.EditValue);
                _vehicle.Color = _colorManagementService.GetColor((int) cmbColor.EditValue);
                _vehicle.MotorCc = Convert.ToInt32(txtMotorCc.Text);
                _vehicle.MotorType = _motorTypeManagementService.GetMotorType((int) cmbMotorType.EditValue);
                _vehicle.TransmissionType = _transmissionTypeManagementService.GetTransmissionType((int)cmbTransmissionType.EditValue);
                _vehicle.Type = _vehicleTypeManagementService.GetVehicleType((int) cmbType.EditValue);
                _vehicle.Year = (int) cmbYear.EditValue;

                _vehicleManagementService.Update(_vehicle);

                Notifier.ShowEditSuccessMessage();
            }
            else
            {
                _vehicleManagementService.Add(new Business.Models.Vehicle
                {
                    LicensePlate = txtLicencePlate.Text,
                    Model = _vehicleModelManagementService.GetVehicleModel((int) cmbModel.EditValue),
                    Color = _colorManagementService.GetColor((int) cmbColor.EditValue),
                    MotorCc = Convert.ToInt32(txtMotorCc.Text),
                    MotorType = _motorTypeManagementService.GetMotorType((int) cmbMotorType.EditValue),
                    Type = _vehicleTypeManagementService.GetVehicleType((int) cmbType.EditValue),
                    TransmissionType = _transmissionTypeManagementService.GetTransmissionType((int)cmbTransmissionType.EditValue),
                    Year = (int) cmbYear.EditValue
                });

                Notifier.ShowAddSuccessMessage();
            }

            Close();
        }

       
    }
}
