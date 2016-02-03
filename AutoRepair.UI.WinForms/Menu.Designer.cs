namespace AutoRepair.UI.WinForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnVehicles = new DevExpress.XtraBars.BarButtonItem();
            this.btnVehicleMakes = new DevExpress.XtraBars.BarButtonItem();
            this.btnVehicleModels = new DevExpress.XtraBars.BarButtonItem();
            this.btnVehicleColors = new DevExpress.XtraBars.BarButtonItem();
            this.btnMotorTypes = new DevExpress.XtraBars.BarButtonItem();
            this.btnVehicleTypes = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductCategories = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductMakes = new DevExpress.XtraBars.BarButtonItem();
            this.btnServiceOrders = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransmissionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnClient,
            this.btnProducts,
            this.btnVehicles,
            this.btnVehicleMakes,
            this.btnVehicleModels,
            this.btnVehicleColors,
            this.btnMotorTypes,
            this.btnVehicleTypes,
            this.btnProductCategories,
            this.btnProductMakes,
            this.btnServiceOrders,
            this.btnTransmissionTypes});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(603, 143);
            // 
            // btnClient
            // 
            this.btnClient.Caption = "Clientes";
            this.btnClient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClient.Glyph")));
            this.btnClient.Id = 1;
            this.btnClient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClient.LargeGlyph")));
            this.btnClient.Name = "btnClient";
            this.btnClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClient_ItemClick);
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Productos";
            this.btnProducts.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProducts.Glyph")));
            this.btnProducts.Id = 2;
            this.btnProducts.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProducts.LargeGlyph")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducts_ItemClick);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Caption = "Vehiculos";
            this.btnVehicles.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVehicles.Glyph")));
            this.btnVehicles.Id = 3;
            this.btnVehicles.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVehicles.LargeGlyph")));
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVehicles_ItemClick);
            // 
            // btnVehicleMakes
            // 
            this.btnVehicleMakes.Caption = "Marcas";
            this.btnVehicleMakes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleMakes.Glyph")));
            this.btnVehicleMakes.Id = 4;
            this.btnVehicleMakes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleMakes.LargeGlyph")));
            this.btnVehicleMakes.Name = "btnVehicleMakes";
            this.btnVehicleMakes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVehicleMakes_ItemClick);
            // 
            // btnVehicleModels
            // 
            this.btnVehicleModels.Caption = "Modelos";
            this.btnVehicleModels.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleModels.Glyph")));
            this.btnVehicleModels.Id = 5;
            this.btnVehicleModels.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleModels.LargeGlyph")));
            this.btnVehicleModels.Name = "btnVehicleModels";
            this.btnVehicleModels.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVehicleModels_ItemClick);
            // 
            // btnVehicleColors
            // 
            this.btnVehicleColors.Caption = "Colores";
            this.btnVehicleColors.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleColors.Glyph")));
            this.btnVehicleColors.Id = 6;
            this.btnVehicleColors.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleColors.LargeGlyph")));
            this.btnVehicleColors.Name = "btnVehicleColors";
            this.btnVehicleColors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVehicleColors_ItemClick);
            // 
            // btnMotorTypes
            // 
            this.btnMotorTypes.Caption = "Tipo de Motores";
            this.btnMotorTypes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMotorTypes.Glyph")));
            this.btnMotorTypes.Id = 7;
            this.btnMotorTypes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMotorTypes.LargeGlyph")));
            this.btnMotorTypes.Name = "btnMotorTypes";
            this.btnMotorTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMotorTypes_ItemClick);
            // 
            // btnVehicleTypes
            // 
            this.btnVehicleTypes.Caption = "Tipo de Vehiculos";
            this.btnVehicleTypes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleTypes.Glyph")));
            this.btnVehicleTypes.Id = 8;
            this.btnVehicleTypes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnVehicleTypes.LargeGlyph")));
            this.btnVehicleTypes.Name = "btnVehicleTypes";
            this.btnVehicleTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVehicleTypes_ItemClick);
            // 
            // btnProductCategories
            // 
            this.btnProductCategories.Caption = "Categorias";
            this.btnProductCategories.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProductCategories.Glyph")));
            this.btnProductCategories.Id = 9;
            this.btnProductCategories.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProductCategories.LargeGlyph")));
            this.btnProductCategories.Name = "btnProductCategories";
            this.btnProductCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductCategories_ItemClick);
            // 
            // btnProductMakes
            // 
            this.btnProductMakes.Caption = "Marcas de Productos";
            this.btnProductMakes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProductMakes.Glyph")));
            this.btnProductMakes.Id = 10;
            this.btnProductMakes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProductMakes.LargeGlyph")));
            this.btnProductMakes.Name = "btnProductMakes";
            this.btnProductMakes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductMakes_ItemClick);
            // 
            // btnServiceOrders
            // 
            this.btnServiceOrders.Caption = "Ordenes de Servicio";
            this.btnServiceOrders.Glyph = ((System.Drawing.Image)(resources.GetObject("btnServiceOrders.Glyph")));
            this.btnServiceOrders.Id = 11;
            this.btnServiceOrders.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnServiceOrders.LargeGlyph")));
            this.btnServiceOrders.Name = "btnServiceOrders";
            this.btnServiceOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnServiceOrders_ItemClick);
            // 
            // btnTransmissionTypes
            // 
            this.btnTransmissionTypes.Caption = "Tipo de Transmisiones";
            this.btnTransmissionTypes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTransmissionTypes.Glyph")));
            this.btnTransmissionTypes.Id = 12;
            this.btnTransmissionTypes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTransmissionTypes.LargeGlyph")));
            this.btnTransmissionTypes.Name = "btnTransmissionTypes";
            this.btnTransmissionTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransmissionTypes_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu Principal";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClient);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVehicles);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnServiceOrders);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Mantenimientos Generales";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnVehicleMakes);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnVehicleModels);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnVehicleColors);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMotorTypes);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnVehicleTypes);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTransmissionTypes);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Vehiculos";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnProductCategories);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnProductMakes);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Productos";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 404);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnClient;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnVehicles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnVehicleMakes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnVehicleModels;
        private DevExpress.XtraBars.BarButtonItem btnVehicleColors;
        private DevExpress.XtraBars.BarButtonItem btnMotorTypes;
        private DevExpress.XtraBars.BarButtonItem btnVehicleTypes;
        private DevExpress.XtraBars.BarButtonItem btnProductCategories;
        private DevExpress.XtraBars.BarButtonItem btnProductMakes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnServiceOrders;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnTransmissionTypes;
    }
}