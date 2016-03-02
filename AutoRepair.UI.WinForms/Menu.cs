using System;
using AutoRepair.DataAccess.Entities;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.Admin;
using AutoRepair.UI.WinForms.Forms.Client;
using AutoRepair.UI.WinForms.Forms.GeneralCruds;
using AutoRepair.UI.WinForms.Forms.Product;
using AutoRepair.UI.WinForms.Forms.User;
using AutoRepair.UI.WinForms.Forms.Vehicle;
using AutoRepair.UI.WinForms.Forms.WorkOrder;

namespace AutoRepair.UI.WinForms
{
    public partial class Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu()
        {
            InitializeComponent();
            SetPermissionsByUserType(Commons.Helper.User.Type);
        }

        private void SetPermissionsByUserType(UserType userType)
        {
            switch (userType)
            {
                case UserType.Normal:
                    ribbonPageGroupAdmin.Visible = false;
                    break;
                case UserType.Administrator:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(userType), userType, null);
            }
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

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var users = new frmUserManagement(FormName.Users);
            users.ShowDialog();
        }

        private void Menu_Load(object sender, System.EventArgs e)
        {
            lbUserNameStatusBar.Caption = Commons.Helper.User.Name;
            lbUserTypeStatusBar.Caption = Commons.Helper.User.Type.ToString();
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void btnReportByUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmReportByUser = new frmReportByUser {ReportType = ReportType.Users};
            frmReportByUser.ShowDialog();
        }

        private void btnProfitReportButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmReportByUser = new frmReportByUser { ReportType = ReportType.GrossProfit };
            frmReportByUser.ShowDialog();
        }
    }
}
