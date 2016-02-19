using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using CustomExceptions;

namespace AutoRepair.UI.WinForms.Forms.Login
{
    public partial class frmLogin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ILoginManagementService _loginManagementService;

        public frmLogin()
        {
            InitializeComponent();
            _loginManagementService = CompositionRoot.Resolve<ILoginManagementService>();
        }

        public Business.Models.User User { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login()
        {
            if(!dxValidationProviderIsNullOrEmpty.Validate())
                return;

            try
            {
                User = _loginManagementService.Login(txtUserName.Text, txtPassword.Text);
                Close();
            }
            catch (LoginFailureException)
            {
                Notifier.LoginFailure();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Login();
            }
        }

        
    }
}
