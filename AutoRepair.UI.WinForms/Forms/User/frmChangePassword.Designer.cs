namespace AutoRepair.UI.WinForms.Forms.User
{
    partial class frmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.cmbUser = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemUsersLookupEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemOldPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemNewPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemConfirmPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderNullOrEmpty = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxValidationProviderMatchPass = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemUsersLookupEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderNullOrEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMatchPass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(115, 60);
            this.txtNewPassword.MenuManager = this.ribbonControl1;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(273, 20);
            this.txtNewPassword.StyleController = this.layoutControl1;
            this.txtNewPassword.TabIndex = 6;
            compareAgainstControlValidationRule2.CaseSensitive = true;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule2.Control = this.txtConfirmPassword;
            compareAgainstControlValidationRule2.ErrorText = "Las contraseñas no coinciden";
            compareAgainstControlValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderMatchPass.SetValidationRule(this.txtNewPassword, compareAgainstControlValidationRule2);
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Ingrese la nueva contraseña";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderNullOrEmpty.SetValidationRule(this.txtNewPassword, conditionValidationRule3);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSave});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(400, 143);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Guardar";
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 1;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtConfirmPassword);
            this.layoutControl1.Controls.Add(this.txtNewPassword);
            this.layoutControl1.Controls.Add(this.txtOldPassword);
            this.layoutControl1.Controls.Add(this.cmbUser);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(400, 131);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(115, 84);
            this.txtConfirmPassword.MenuManager = this.ribbonControl1;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(273, 20);
            this.txtConfirmPassword.StyleController = this.layoutControl1;
            this.txtConfirmPassword.TabIndex = 7;
            compareAgainstControlValidationRule1.CaseSensitive = true;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.txtNewPassword;
            compareAgainstControlValidationRule1.ErrorText = "Las contraseñas no coinciden";
            compareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderMatchPass.SetValidationRule(this.txtConfirmPassword, compareAgainstControlValidationRule1);
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Ingrese nuevamente la contraseña";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderNullOrEmpty.SetValidationRule(this.txtConfirmPassword, conditionValidationRule1);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(115, 36);
            this.txtOldPassword.MenuManager = this.ribbonControl1;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(273, 20);
            this.txtOldPassword.StyleController = this.layoutControl1;
            this.txtOldPassword.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Ingrese la contraseña";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProviderNullOrEmpty.SetValidationRule(this.txtOldPassword, conditionValidationRule2);
            // 
            // cmbUser
            // 
            this.cmbUser.Location = new System.Drawing.Point(115, 12);
            this.cmbUser.MenuManager = this.ribbonControl1;
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUser.Size = new System.Drawing.Size(273, 20);
            this.cmbUser.StyleController = this.layoutControl1;
            this.cmbUser.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemUsersLookupEdit,
            this.itemOldPassword,
            this.itemNewPassword,
            this.itemConfirmPassword});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 131);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // itemUsersLookupEdit
            // 
            this.itemUsersLookupEdit.Control = this.cmbUser;
            this.itemUsersLookupEdit.Location = new System.Drawing.Point(0, 0);
            this.itemUsersLookupEdit.Name = "itemUsersLookupEdit";
            this.itemUsersLookupEdit.Size = new System.Drawing.Size(380, 24);
            this.itemUsersLookupEdit.Text = "Usuario";
            this.itemUsersLookupEdit.TextSize = new System.Drawing.Size(100, 13);
            // 
            // itemOldPassword
            // 
            this.itemOldPassword.Control = this.txtOldPassword;
            this.itemOldPassword.Location = new System.Drawing.Point(0, 24);
            this.itemOldPassword.Name = "itemOldPassword";
            this.itemOldPassword.Size = new System.Drawing.Size(380, 24);
            this.itemOldPassword.Text = "Contraseña actual";
            this.itemOldPassword.TextSize = new System.Drawing.Size(100, 13);
            // 
            // itemNewPassword
            // 
            this.itemNewPassword.Control = this.txtNewPassword;
            this.itemNewPassword.Location = new System.Drawing.Point(0, 48);
            this.itemNewPassword.Name = "itemNewPassword";
            this.itemNewPassword.Size = new System.Drawing.Size(380, 24);
            this.itemNewPassword.Text = "Contraseña nueva";
            this.itemNewPassword.TextSize = new System.Drawing.Size(100, 13);
            // 
            // itemConfirmPassword
            // 
            this.itemConfirmPassword.Control = this.txtConfirmPassword;
            this.itemConfirmPassword.Location = new System.Drawing.Point(0, 72);
            this.itemConfirmPassword.Name = "itemConfirmPassword";
            this.itemConfirmPassword.Size = new System.Drawing.Size(380, 39);
            this.itemConfirmPassword.Text = "Confirme contraseña";
            this.itemConfirmPassword.TextSize = new System.Drawing.Size(100, 13);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 274);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemUsersLookupEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderNullOrEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMatchPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.TextEdit txtOldPassword;
        private DevExpress.XtraEditors.LookUpEdit cmbUser;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem itemUsersLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem itemOldPassword;
        private DevExpress.XtraLayout.LayoutControlItem itemNewPassword;
        private DevExpress.XtraLayout.LayoutControlItem itemConfirmPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderNullOrEmpty;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMatchPass;
    }
}