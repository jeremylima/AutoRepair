using AutoRepair.UI.WinForms.Forms.Client;
using AutoRepair.UI.WinForms.Forms.Product;
using AutoRepair.UI.WinForms.Forms.Vehicle;

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
    }
}
