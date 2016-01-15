namespace AutoRepair.UI.WinForms.Forms.Vehicle
{
    partial class frmVehicleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleManagement));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewVehicle = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditVehicle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteVehicle = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvVehicleList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNewVehicle,
            this.btnEditVehicle,
            this.btnDeleteVehicle});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1102, 162);
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Caption = "Nuevo";
            this.btnNewVehicle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNewVehicle.Glyph")));
            this.btnNewVehicle.Id = 1;
            this.btnNewVehicle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNewVehicle.LargeGlyph")));
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewVehicle_ItemClick);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Caption = "Editar";
            this.btnEditVehicle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditVehicle.Glyph")));
            this.btnEditVehicle.Id = 2;
            this.btnEditVehicle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditVehicle.LargeGlyph")));
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnEditVehicle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditVehicle_ItemClick);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Caption = "Eliminar";
            this.btnDeleteVehicle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteVehicle.Glyph")));
            this.btnDeleteVehicle.Id = 3;
            this.btnDeleteVehicle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteVehicle.LargeGlyph")));
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDeleteVehicle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteVehicle_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewVehicle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditVehicle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteVehicle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvVehicleList.Location = new System.Drawing.Point(0, 162);
            this.gvVehicleList.MainView = this.gridView1;
            this.gvVehicleList.MenuManager = this.ribbonControl1;
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.Size = new System.Drawing.Size(1102, 582);
            this.gvVehicleList.TabIndex = 1;
            this.gvVehicleList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvVehicleList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // frmVehicleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 744);
            this.Controls.Add(this.gvVehicleList);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmVehicleManagement";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmVehicleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNewVehicle;
        private DevExpress.XtraBars.BarButtonItem btnEditVehicle;
        private DevExpress.XtraBars.BarButtonItem btnDeleteVehicle;
        private DevExpress.XtraGrid.GridControl gvVehicleList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}