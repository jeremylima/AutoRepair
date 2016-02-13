namespace AutoRepair.UI.WinForms.Forms.User
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.IsSystemUserCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.TypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ProfitPercentageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsSystemUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProfitPercentage = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSystemUserCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitPercentageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsSystemUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProfitPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(600, 143);
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.IsSystemUserCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.TypeImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.ProfitPercentageTextEdit);
            this.dataLayoutControl1.DataSource = this.userBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 143);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(600, 202);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Id", true));
            this.IdTextEdit.Location = new System.Drawing.Point(99, 12);
            this.IdTextEdit.MenuManager = this.ribbonControl1;
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdTextEdit.Properties.Mask.EditMask = "N0";
            this.IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdTextEdit.Size = new System.Drawing.Size(489, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 4;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AutoRepair.Business.Models.User);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(128, 12);
            this.NameTextEdit.MenuManager = this.ribbonControl1;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(460, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "UserName", true));
            this.UserNameTextEdit.Location = new System.Drawing.Point(128, 36);
            this.UserNameTextEdit.MenuManager = this.ribbonControl1;
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Size = new System.Drawing.Size(460, 20);
            this.UserNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UserNameTextEdit.TabIndex = 6;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Password", true));
            this.PasswordTextEdit.Location = new System.Drawing.Point(128, 60);
            this.PasswordTextEdit.MenuManager = this.ribbonControl1;
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Properties.PasswordChar = '*';
            this.PasswordTextEdit.Size = new System.Drawing.Size(460, 20);
            this.PasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.PasswordTextEdit.TabIndex = 7;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "IsActive", true));
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(128, 84);
            this.IsActiveCheckEdit.MenuManager = this.ribbonControl1;
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "";
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(460, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 8;
            // 
            // IsSystemUserCheckEdit
            // 
            this.IsSystemUserCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "IsSystemUser", true));
            this.IsSystemUserCheckEdit.Location = new System.Drawing.Point(128, 107);
            this.IsSystemUserCheckEdit.MenuManager = this.ribbonControl1;
            this.IsSystemUserCheckEdit.Name = "IsSystemUserCheckEdit";
            this.IsSystemUserCheckEdit.Properties.Caption = "";
            this.IsSystemUserCheckEdit.Size = new System.Drawing.Size(460, 19);
            this.IsSystemUserCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsSystemUserCheckEdit.TabIndex = 9;
            // 
            // TypeImageComboBoxEdit
            // 
            this.TypeImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Type", true));
            this.TypeImageComboBoxEdit.Location = new System.Drawing.Point(128, 130);
            this.TypeImageComboBoxEdit.MenuManager = this.ribbonControl1;
            this.TypeImageComboBoxEdit.Name = "TypeImageComboBoxEdit";
            this.TypeImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TypeImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Administrator", AutoRepair.DataAccess.Entities.UserType.Administrator, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", AutoRepair.DataAccess.Entities.UserType.Normal, 1)});
            this.TypeImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.TypeImageComboBoxEdit.Size = new System.Drawing.Size(170, 20);
            this.TypeImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.TypeImageComboBoxEdit.TabIndex = 10;
            // 
            // ProfitPercentageTextEdit
            // 
            this.ProfitPercentageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "ProfitPercentage", true));
            this.ProfitPercentageTextEdit.Location = new System.Drawing.Point(128, 154);
            this.ProfitPercentageTextEdit.MenuManager = this.ribbonControl1;
            this.ProfitPercentageTextEdit.Name = "ProfitPercentageTextEdit";
            this.ProfitPercentageTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ProfitPercentageTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ProfitPercentageTextEdit.Properties.Mask.EditMask = "p";
            this.ProfitPercentageTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ProfitPercentageTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ProfitPercentageTextEdit.Size = new System.Drawing.Size(170, 20);
            this.ProfitPercentageTextEdit.StyleController = this.dataLayoutControl1;
            this.ProfitPercentageTextEdit.TabIndex = 11;
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(580, 24);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(600, 202);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForUserName,
            this.ItemForPassword,
            this.ItemForIsActive,
            this.ItemForIsSystemUser,
            this.ItemForType,
            this.ItemForProfitPercentage,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(580, 182);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(580, 24);
            this.ItemForName.Text = "Nombre";
            this.ItemForName.TextSize = new System.Drawing.Size(113, 13);
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameTextEdit;
            this.ItemForUserName.Location = new System.Drawing.Point(0, 24);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(580, 24);
            this.ItemForUserName.Text = "Usuario";
            this.ItemForUserName.TextSize = new System.Drawing.Size(113, 13);
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTextEdit;
            this.ItemForPassword.Location = new System.Drawing.Point(0, 48);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(580, 24);
            this.ItemForPassword.Text = "Contraseña";
            this.ItemForPassword.TextSize = new System.Drawing.Size(113, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(0, 72);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(580, 23);
            this.ItemForIsActive.Text = "Activo";
            this.ItemForIsActive.TextSize = new System.Drawing.Size(113, 13);
            // 
            // ItemForIsSystemUser
            // 
            this.ItemForIsSystemUser.Control = this.IsSystemUserCheckEdit;
            this.ItemForIsSystemUser.Location = new System.Drawing.Point(0, 95);
            this.ItemForIsSystemUser.Name = "ItemForIsSystemUser";
            this.ItemForIsSystemUser.Size = new System.Drawing.Size(580, 23);
            this.ItemForIsSystemUser.Text = "Es Usuario de Sistema";
            this.ItemForIsSystemUser.TextSize = new System.Drawing.Size(113, 13);
            // 
            // ItemForType
            // 
            this.ItemForType.Control = this.TypeImageComboBoxEdit;
            this.ItemForType.Location = new System.Drawing.Point(0, 118);
            this.ItemForType.Name = "ItemForType";
            this.ItemForType.Size = new System.Drawing.Size(290, 24);
            this.ItemForType.Text = "Tipo de Usuario";
            this.ItemForType.TextSize = new System.Drawing.Size(113, 13);
            // 
            // ItemForProfitPercentage
            // 
            this.ItemForProfitPercentage.Control = this.ProfitPercentageTextEdit;
            this.ItemForProfitPercentage.Location = new System.Drawing.Point(0, 142);
            this.ItemForProfitPercentage.Name = "ItemForProfitPercentage";
            this.ItemForProfitPercentage.Size = new System.Drawing.Size(290, 40);
            this.ItemForProfitPercentage.Text = "Porcentaje de ganancia";
            this.ItemForProfitPercentage.TextSize = new System.Drawing.Size(113, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(290, 118);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(290, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(290, 142);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(290, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.userBindingSource;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 345);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmUser";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario de Sistema";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsSystemUserCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitPercentageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsSystemUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProfitPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraEditors.CheckEdit IsSystemUserCheckEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit TypeImageComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit ProfitPercentageTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsSystemUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProfitPercentage;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}