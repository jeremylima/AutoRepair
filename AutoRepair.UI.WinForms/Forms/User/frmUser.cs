using System;
using System.ComponentModel;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using CustomExceptions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;

namespace AutoRepair.UI.WinForms.Forms.User
{
    public partial class frmUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.User _user { get; set; }
        public IUserManagementService _userManagementService;
        public frmUser()
        {
            InitializeComponent();
            _userManagementService = CompositionRoot.Resolve<IUserManagementService>();

            foreach (Control ctrl in dataLayoutControl1.Controls)
            {
                ctrl.Validating += te_Validating;
            }

        }

        void te_Validating(object sender, CancelEventArgs e)
        {
            BaseEdit edit = sender as BaseEdit;
            if (e.Cancel)
            {
                BaseEditValidatingEventArgs ea = e as BaseEditValidatingEventArgs;
                if (ea.ErrorText != "")
                    dxErrorProvider1.SetError(edit, ea.ErrorText);
            }
            else
                dxErrorProvider1.SetError(edit, ""); 
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Validator.Validate(dataLayoutControl1.Controls);
            if (dxErrorProvider1.GetControlsWithError().Count > 0)
                return;

            try
            {
                if (_user != null)
                {
                    _userManagementService.Update((Business.Models.User) userBindingSource.Current);

                    Notifier.ShowEditSuccessMessage();
                }
                else
                {
                    _userManagementService.Add((Business.Models.User) userBindingSource.Current);

                    Notifier.ShowAddSuccessMessage();
                }

                Close();
            }
            catch (DuplicatedEntryKeyException)
            {
                Notifier.DuplicatedEntry();
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                userBindingSource.DataSource = new Business.Models.User();
            }
            else
            {
                _user.Password = "-";
                userBindingSource.DataSource = _user;
                ItemForPassword.Visibility = LayoutVisibility.Never;
            }

            dxErrorProvider1.DataSource = userBindingSource;
            dataLayoutControl1.Validate();
        }
    }
}
