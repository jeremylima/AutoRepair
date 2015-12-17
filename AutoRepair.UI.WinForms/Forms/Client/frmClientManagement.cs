using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using DevExpress.XtraGrid.Views.Grid;

namespace AutoRepair.UI.WinForms.Forms.Client
{
    public partial class frmClientManagement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IClientManagementService _clientManagementService;

        public frmClientManagement()
        {
            _clientManagementService = CompositionRoot.Resolve<IClientManagementService>() ;
            InitializeComponent();
        }

        private void frmClientManagement_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customerList = _clientManagementService.GetAllClients();
            gvClientList.DataSource = customerList;
        }

        private void btnNewClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var client = new frmClient();
            client.ShowDialog();
            
            LoadCustomers();
        }

        private void btnEditClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var client = (Business.Models.Client)(gvClientList.FocusedView as GridView).GetRow(rowHandle);

                var frmClient = new frmClient {_client = client };
                frmClient.ShowDialog();
                LoadCustomers();
            }

        }

        private void btnDeleteClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var client = (Business.Models.Client)(gvClientList.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _clientManagementService.Delete(client);
                    LoadCustomers();
                } 
            }
        }
    }
}
