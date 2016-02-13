using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.DataAccess.Entities;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;

namespace AutoRepair.UI.WinForms.Forms.User
{
    public partial class frmChangePassword : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IUserManagementService _userManagementService;
        public frmChangePassword()
        {
            InitializeComponent();
            _userManagementService = CompositionRoot.Resolve<IUserManagementService>();
            
        }

        
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            var userSelected = 0;
            if (Commons.Helper.User.Type == UserType.Normal)
            {
                cmbUser.Properties.ReadOnly = true;
                userSelected = Commons.Helper.User.Id;
            }
            else
            {
                itemOldPassword.Visibility= LayoutVisibility.Never;
                txtOldPassword.Text = @"-";
            }

            LoadUser(userSelected);
            
            
        }

        private void LoadUser(int userSelected = 0)
        {
            var users = _userManagementService.GetAllUsers().Select(models => new { models.Id, models.Name });
            ComponentFiller.FillLookUpEdit(cmbUser).Data(users, "Name", "Id", userSelected);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!dxValidationProviderNullOrEmpty.Validate())
                return;

            if (!dxValidationProviderMatchPass.Validate())
                return;

            var passwordChanged = _userManagementService.ChangePassword((int) cmbUser.EditValue, txtNewPassword.Text, txtOldPassword.Text, Commons.Helper.User.Type);

            if (!passwordChanged)
            { 
                Notifier.OldPasswordDoesNotMatch();
                return;
            }

            Notifier.PasswordUpdated();
            Close();
        }
    }
}
