using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.Client;
using AutoRepair.UI.WinForms.Forms.GeneralCruds;
using AutoRepair.UI.WinForms.Forms.Product;
using AutoRepair.UI.WinForms.Forms.Vehicle;
using AutoRepair.UI.WinForms.Forms.WorkOrder;

namespace AutoRepair.UI.WinForms
{
    public partial class Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var clients = new frmClientManagement();
            clients.ShowDialog();
        }

        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var products = new frmProductManagement();
            products.ShowDialog();
        }

        private void btnVehicles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var vehicles = new frmVehicleManagement();
            vehicles.ShowDialog();
        }

        private void btnTransmissionTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var transmissionTypes = new frmTransmissionTypeManagement(FormName.TransmissionTypes);
            transmissionTypes.ShowDialog();
        }

        private void btnServiceOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var workOrders = new frmWorkOrderManagement();
            workOrders.ShowDialog();
        }

        private void btnProductCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var categories = new frmCategoryManagement(FormName.Categories);
            categories.ShowDialog();

        }

        private void btnVehicleColors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var colors = new frmColorManagement(FormName.Colors);
            colors.ShowDialog();
        }

        private void btnProductMakes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var productMakes = new frmProductMakeManagement(FormName.ProductMakes);
            productMakes.ShowDialog();
        }

        private void btnVehicleMakes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var vehicleMakes = new frmVehicleMakeManagement(FormName.VehicleMakes);
            vehicleMakes.ShowDialog();
        }

        private void btnMotorTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var motorTypes = new frmMotorTypeManagement(FormName.MotorTypes);
            motorTypes.ShowDialog();
        }

        private void btnVehicleTypes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var vehicleTypes = new frmVehicleTypeManagement(FormName.VehicleTypes);
            vehicleTypes.ShowDialog();
        }

        private void btnVehicleModels_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var vehicleModels = new frmVehicleModelManagement(FormName.VehicleModels);
            vehicleModels.ShowDialog();
        }
    }
}
