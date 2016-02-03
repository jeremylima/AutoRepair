using System;
using System.Data.Services.Providers;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;

namespace AutoRepair.UI.WinForms.Forms.Client
{
    public partial class frmClient : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.Client _client { get; set; }
        public IClientManagementService _clientManagementService;
        public frmClient()
        {
            InitializeComponent();
            _clientManagementService = CompositionRoot.Resolve<IClientManagementService>() ;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            if (_client != null)
            {
                txtNit.Text = _client.Nit;
                txtFirstName.Text = _client.FirstName;
                txtLastName.Text = _client.LastName;
                txtMobile.Text = _client.MobilePhone;
                txtPhone.Text = _client.Phone;
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_client != null)
            {
                _client.Nit = txtNit.Text;
                _client.FirstName = txtFirstName.Text;
                _client.LastName = txtLastName.Text;
                _client.MobilePhone = txtMobile.Text;
                _client.Phone = txtPhone.Text;

                _clientManagementService.Update(_client);

                Notifier.ShowEditSuccessMessage();
            }
            else
            {
                _clientManagementService.Add(new Business.Models.Client
                {
                    Nit = txtNit.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MobilePhone = txtMobile.Text,
                    Phone = txtPhone.Text
                });

                Notifier.ShowAddSuccessMessage();
                
            }

            Close();
        }
    }
}
