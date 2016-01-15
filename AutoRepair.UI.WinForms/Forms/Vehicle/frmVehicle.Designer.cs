namespace AutoRepair.UI.WinForms.Forms.Vehicle
{
    partial class frmVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicle));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLicencePlate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMotorCc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMake = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbModel = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbType = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbColor = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbYear = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbMotorType = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTransmissionType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicencePlate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotorCc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMake.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotorType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransmissionType.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(371, 143);
            
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 169);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "No. Placa";
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(120, 166);
            this.txtLicencePlate.MenuManager = this.ribbonControl1;
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(225, 20);
            this.txtLicencePlate.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 201);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Marca";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 233);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Modelo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 329);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Año";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 393);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Tipo de Motor";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 425);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Motor CC";
            // 
            // txtMotorCc
            // 
            this.txtMotorCc.Location = new System.Drawing.Point(120, 422);
            this.txtMotorCc.MenuManager = this.ribbonControl1;
            this.txtMotorCc.Name = "txtMotorCc";
            this.txtMotorCc.Size = new System.Drawing.Size(225, 20);
            this.txtMotorCc.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 297);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Color";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 265);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(20, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Tipo";
            // 
            // cmbMake
            // 
            this.cmbMake.Location = new System.Drawing.Point(120, 198);
            this.cmbMake.MenuManager = this.ribbonControl1;
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMake.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbMake.Size = new System.Drawing.Size(225, 20);
            this.cmbMake.TabIndex = 24;
            // 
            // cmbModel
            // 
            this.cmbModel.Location = new System.Drawing.Point(120, 230);
            this.cmbModel.MenuManager = this.ribbonControl1;
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbModel.Size = new System.Drawing.Size(225, 20);
            this.cmbModel.TabIndex = 25;
            this.cmbModel.Enter += new System.EventHandler(this.cmbModel_Enter);
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(120, 262);
            this.cmbType.MenuManager = this.ribbonControl1;
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbType.Size = new System.Drawing.Size(225, 20);
            this.cmbType.TabIndex = 26;
            // 
            // cmbColor
            // 
            this.cmbColor.Location = new System.Drawing.Point(120, 294);
            this.cmbColor.MenuManager = this.ribbonControl1;
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbColor.Size = new System.Drawing.Size(225, 20);
            this.cmbColor.TabIndex = 27;
            // 
            // cmbYear
            // 
            this.cmbYear.Location = new System.Drawing.Point(120, 326);
            this.cmbYear.MenuManager = this.ribbonControl1;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbYear.Size = new System.Drawing.Size(225, 20);
            this.cmbYear.TabIndex = 28;
            // 
            // cmbMotorType
            // 
            this.cmbMotorType.Location = new System.Drawing.Point(120, 390);
            this.cmbMotorType.MenuManager = this.ribbonControl1;
            this.cmbMotorType.Name = "cmbMotorType";
            this.cmbMotorType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotorType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbMotorType.Size = new System.Drawing.Size(225, 20);
            this.cmbMotorType.TabIndex = 29;
            // 
            // cmbTransmissionType
            // 
            this.cmbTransmissionType.Location = new System.Drawing.Point(120, 358);
            this.cmbTransmissionType.MenuManager = this.ribbonControl1;
            this.cmbTransmissionType.Name = "cmbTransmissionType";
            this.cmbTransmissionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTransmissionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTransmissionType.Size = new System.Drawing.Size(225, 20);
            this.cmbTransmissionType.TabIndex = 30;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 361);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(94, 13);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Tipo de Transmision";
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 467);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.cmbTransmissionType);
            this.Controls.Add(this.cmbMotorType);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtMotorCc);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLicencePlate);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehicle";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculo";
            this.Activated += new System.EventHandler(this.frmVehicle_Activated);
            this.Load += new System.EventHandler(this.frmVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicencePlate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotorCc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMake.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotorType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransmissionType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLicencePlate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMotorCc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cmbMake;
        private DevExpress.XtraEditors.LookUpEdit cmbModel;
        private DevExpress.XtraEditors.LookUpEdit cmbType;
        private DevExpress.XtraEditors.LookUpEdit cmbColor;
        private DevExpress.XtraEditors.LookUpEdit cmbYear;
        private DevExpress.XtraEditors.LookUpEdit cmbMotorType;
        private DevExpress.XtraEditors.LookUpEdit cmbTransmissionType;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}