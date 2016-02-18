namespace AutoRepair.UI.WinForms.Forms.Admin
{
    partial class frmReportByUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportByUser));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnViewReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbUser = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemUsersLookupEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateEditInitDate = new DevExpress.XtraEditors.DateEdit();
            this.itemInitialDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateEditEndDate = new DevExpress.XtraEditors.DateEdit();
            this.itemEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemUsersLookupEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInitDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInitDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInitialDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEndDate)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnViewReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(465, 143);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Caption = "Ver Reporte";
            this.btnViewReport.Glyph = ((System.Drawing.Image)(resources.GetObject("btnViewReport.Glyph")));
            this.btnViewReport.Id = 1;
            this.btnViewReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnViewReport.LargeGlyph")));
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewReport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnViewReport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateEditEndDate);
            this.layoutControl1.Controls.Add(this.dateEditInitDate);
            this.layoutControl1.Controls.Add(this.cmbUser);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(465, 87);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbUser
            // 
            this.cmbUser.Location = new System.Drawing.Point(74, 12);
            this.cmbUser.MenuManager = this.ribbonControl1;
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUser.Size = new System.Drawing.Size(379, 20);
            this.cmbUser.StyleController = this.layoutControl1;
            this.cmbUser.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemUsersLookupEdit,
            this.itemInitialDate,
            this.itemEndDate});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(465, 87);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // itemUsersLookupEdit
            // 
            this.itemUsersLookupEdit.Control = this.cmbUser;
            this.itemUsersLookupEdit.Location = new System.Drawing.Point(0, 0);
            this.itemUsersLookupEdit.Name = "itemUsersLookupEdit";
            this.itemUsersLookupEdit.Size = new System.Drawing.Size(445, 24);
            this.itemUsersLookupEdit.Text = "Empleado";
            this.itemUsersLookupEdit.TextSize = new System.Drawing.Size(59, 13);
            // 
            // dateEditInitDate
            // 
            this.dateEditInitDate.EditValue = null;
            this.dateEditInitDate.Location = new System.Drawing.Point(74, 36);
            this.dateEditInitDate.MenuManager = this.ribbonControl1;
            this.dateEditInitDate.Name = "dateEditInitDate";
            this.dateEditInitDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInitDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInitDate.Size = new System.Drawing.Size(156, 20);
            this.dateEditInitDate.StyleController = this.layoutControl1;
            this.dateEditInitDate.TabIndex = 5;
            // 
            // itemInitialDate
            // 
            this.itemInitialDate.Control = this.dateEditInitDate;
            this.itemInitialDate.Location = new System.Drawing.Point(0, 24);
            this.itemInitialDate.Name = "itemInitialDate";
            this.itemInitialDate.Size = new System.Drawing.Size(222, 43);
            this.itemInitialDate.Text = "Fecha Inicial";
            this.itemInitialDate.TextSize = new System.Drawing.Size(59, 13);
            // 
            // dateEditEndDate
            // 
            this.dateEditEndDate.EditValue = null;
            this.dateEditEndDate.Location = new System.Drawing.Point(296, 36);
            this.dateEditEndDate.MenuManager = this.ribbonControl1;
            this.dateEditEndDate.Name = "dateEditEndDate";
            this.dateEditEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEndDate.Size = new System.Drawing.Size(157, 20);
            this.dateEditEndDate.StyleController = this.layoutControl1;
            this.dateEditEndDate.TabIndex = 6;
            // 
            // itemEndDate
            // 
            this.itemEndDate.Control = this.dateEditEndDate;
            this.itemEndDate.Location = new System.Drawing.Point(222, 24);
            this.itemEndDate.Name = "itemEndDate";
            this.itemEndDate.Size = new System.Drawing.Size(223, 43);
            this.itemEndDate.Text = "Fecha Final";
            this.itemEndDate.TextSize = new System.Drawing.Size(59, 13);
            // 
            // frmReportByUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 230);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmReportByUser";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Por Empleado";
            this.Load += new System.EventHandler(this.frmReportByUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemUsersLookupEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInitDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInitDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInitialDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEndDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnViewReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dateEditEndDate;
        private DevExpress.XtraEditors.DateEdit dateEditInitDate;
        private DevExpress.XtraEditors.LookUpEdit cmbUser;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem itemUsersLookupEdit;
        private DevExpress.XtraLayout.LayoutControlItem itemInitialDate;
        private DevExpress.XtraLayout.LayoutControlItem itemEndDate;
    }
}