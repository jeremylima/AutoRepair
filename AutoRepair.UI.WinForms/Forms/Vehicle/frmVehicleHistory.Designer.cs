namespace AutoRepair.UI.WinForms.Forms.Vehicle
{
    partial class frmVehicleHistory
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleHistory));
            this.viewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvWorkOrders = new DevExpress.XtraGrid.GridControl();
            this.viewServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewWorkOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemoOrderDescription = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnExpandAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnCollapseAll = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MemoDescription = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gvVehicle = new DevExpress.XtraGrid.GridControl();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.viewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWorkOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoOrderDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewProducts
            // 
            this.viewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodProduct,
            this.colProductDescription,
            this.colProductQuantity});
            this.viewProducts.GridControl = this.gvWorkOrders;
            this.viewProducts.Name = "viewProducts";
            this.viewProducts.ViewCaption = "Repuestos / Productos";
            // 
            // colCodProduct
            // 
            this.colCodProduct.Caption = "Codigo Producto";
            this.colCodProduct.FieldName = "Code";
            this.colCodProduct.Name = "colCodProduct";
            this.colCodProduct.Visible = true;
            this.colCodProduct.VisibleIndex = 0;
            this.colCodProduct.Width = 88;
            // 
            // colProductDescription
            // 
            this.colProductDescription.Caption = "Descripcion";
            this.colProductDescription.FieldName = "Product";
            this.colProductDescription.Name = "colProductDescription";
            this.colProductDescription.Visible = true;
            this.colProductDescription.VisibleIndex = 1;
            this.colProductDescription.Width = 556;
            // 
            // colProductQuantity
            // 
            this.colProductQuantity.Caption = "Cantidad";
            this.colProductQuantity.FieldName = "Quantity";
            this.colProductQuantity.Name = "colProductQuantity";
            this.colProductQuantity.Visible = true;
            this.colProductQuantity.VisibleIndex = 2;
            this.colProductQuantity.Width = 72;
            // 
            // gvWorkOrders
            // 
            this.gvWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.viewProducts;
            gridLevelNode1.RelationName = "WorkOrderDetails";
            gridLevelNode2.LevelTemplate = this.viewServices;
            gridLevelNode2.RelationName = "ServiceCosts";
            this.gvWorkOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gvWorkOrders.Location = new System.Drawing.Point(318, 143);
            this.gvWorkOrders.MainView = this.viewWorkOrders;
            this.gvWorkOrders.MenuManager = this.ribbonControl1;
            this.gvWorkOrders.Name = "gvWorkOrders";
            this.gvWorkOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MemoOrderDescription,
            this.MemoDescription});
            this.gvWorkOrders.Size = new System.Drawing.Size(734, 439);
            this.gvWorkOrders.TabIndex = 1;
            this.gvWorkOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewServices,
            this.viewWorkOrders,
            this.viewProducts});
            // 
            // viewServices
            // 
            this.viewServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServiceDescription});
            this.viewServices.GridControl = this.gvWorkOrders;
            this.viewServices.Name = "viewServices";
            this.viewServices.ViewCaption = "Servicios Realizados";
            // 
            // colServiceDescription
            // 
            this.colServiceDescription.Caption = "Descripcion";
            this.colServiceDescription.FieldName = "Description";
            this.colServiceDescription.Name = "colServiceDescription";
            this.colServiceDescription.Visible = true;
            this.colServiceDescription.VisibleIndex = 0;
            // 
            // viewWorkOrders
            // 
            this.viewWorkOrders.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewWorkOrders.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.viewWorkOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId,
            this.colDate,
            this.colWorkOrderDescription});
            this.viewWorkOrders.GridControl = this.gvWorkOrders;
            this.viewWorkOrders.Name = "viewWorkOrders";
            this.viewWorkOrders.OptionsCustomization.AllowRowSizing = true;
            this.viewWorkOrders.OptionsView.AllowHtmlDrawHeaders = true;
            this.viewWorkOrders.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.viewWorkOrders.OptionsView.RowAutoHeight = true;
            // 
            // colOrderId
            // 
            this.colOrderId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOrderId.AppearanceCell.Options.UseFont = true;
            this.colOrderId.AppearanceCell.Options.UseTextOptions = true;
            this.colOrderId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderId.Caption = "No. Orden";
            this.colOrderId.FieldName = "OrderId";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.Visible = true;
            this.colOrderId.VisibleIndex = 0;
            this.colOrderId.Width = 65;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDate.AppearanceCell.Options.UseFont = true;
            this.colDate.Caption = "Fecha";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 82;
            // 
            // colWorkOrderDescription
            // 
            this.colWorkOrderDescription.Caption = "Comentarios / Anotaciones";
            this.colWorkOrderDescription.ColumnEdit = this.MemoOrderDescription;
            this.colWorkOrderDescription.FieldName = "Description";
            this.colWorkOrderDescription.Name = "colWorkOrderDescription";
            this.colWorkOrderDescription.Visible = true;
            this.colWorkOrderDescription.VisibleIndex = 2;
            this.colWorkOrderDescription.Width = 569;
            // 
            // MemoOrderDescription
            // 
            this.MemoOrderDescription.Name = "MemoOrderDescription";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnExpandAll,
            this.btnCollapseAll});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1052, 143);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Caption = "Expandir Todo";
            this.btnExpandAll.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExpandAll.Glyph")));
            this.btnExpandAll.Id = 2;
            this.btnExpandAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExpandAll.LargeGlyph")));
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpandAll_ItemClick);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Caption = "Colapsar Todo";
            this.btnCollapseAll.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCollapseAll.Glyph")));
            this.btnCollapseAll.Id = 3;
            this.btnCollapseAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCollapseAll.LargeGlyph")));
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCollapseAll_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Opciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExpandAll);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCollapseAll);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // MemoDescription
            // 
            this.MemoDescription.Name = "MemoDescription";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("cbd1124b-fe67-4b1b-883d-f664bae660a5");
            this.dockPanel1.Location = new System.Drawing.Point(0, 143);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(318, 200);
            this.dockPanel1.Size = new System.Drawing.Size(318, 439);
            this.dockPanel1.Text = "Informacion del Vehiculo";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gvVehicle);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(310, 412);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gvVehicle
            // 
            this.gvVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvVehicle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVehicle.Location = new System.Drawing.Point(0, 0);
            this.gvVehicle.MainView = this.cardView2;
            this.gvVehicle.MenuManager = this.ribbonControl1;
            this.gvVehicle.Name = "gvVehicle";
            this.gvVehicle.Size = new System.Drawing.Size(310, 412);
            this.gvVehicle.TabIndex = 4;
            this.gvVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView2});
            // 
            // cardView2
            // 
            this.cardView2.Appearance.Card.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView2.Appearance.Card.Options.UseFont = true;
            this.cardView2.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView2.Appearance.CardCaption.Options.UseFont = true;
            this.cardView2.Appearance.FieldCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView2.Appearance.FieldCaption.Options.UseFont = true;
            this.cardView2.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView2.Appearance.FieldValue.Options.UseFont = true;
            this.cardView2.Appearance.FieldValue.Options.UseTextOptions = true;
            this.cardView2.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cardView2.CardWidth = 300;
            this.cardView2.FocusedCardTopFieldIndex = 0;
            this.cardView2.GridControl = this.gvVehicle;
            this.cardView2.Name = "cardView2";
            this.cardView2.OptionsBehavior.Editable = false;
            this.cardView2.OptionsView.ShowCardCaption = false;
            this.cardView2.OptionsView.ShowCardExpandButton = false;
            this.cardView2.OptionsView.ShowFieldHints = false;
            this.cardView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.cardView2.OptionsView.ShowHorzScrollBar = false;
            this.cardView2.OptionsView.ShowQuickCustomizeButton = false;
            // 
            // frmVehicleHistory
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 582);
            this.Controls.Add(this.gvWorkOrders);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmVehicleHistory";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Historial del Vehiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehicleHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWorkOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoOrderDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gvWorkOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView viewWorkOrders;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gvVehicle;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraBars.BarButtonItem btnExpandAll;
        private DevExpress.XtraBars.BarButtonItem btnCollapseAll;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit MemoOrderDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit MemoDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView viewProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView viewServices;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceDescription;
    }
}