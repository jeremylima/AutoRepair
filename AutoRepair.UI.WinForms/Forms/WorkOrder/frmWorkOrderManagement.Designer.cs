namespace AutoRepair.UI.WinForms.Forms.WorkOrder
{
    partial class frmWorkOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkOrderManagement));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnFinalizeWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.radioButtonViewTypeOrders = new DevExpress.XtraBars.BarEditItem();
            this.repositoryRadioButtonViewTypeOrders = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.btnReOpenWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewWorkOrder = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvWorkOrderList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryRadioButtonViewTypeOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNewWorkOrder,
            this.btnEditWorkOrder,
            this.btnDeleteWorkOrder,
            this.btnFinalizeWorkOrder,
            this.radioButtonViewTypeOrders,
            this.btnReOpenWorkOrder,
            this.btnViewWorkOrder});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryRadioButtonViewTypeOrders});
            this.ribbonControl1.Size = new System.Drawing.Size(990, 162);
            // 
            // btnNewWorkOrder
            // 
            this.btnNewWorkOrder.Caption = "Nuevo";
            this.btnNewWorkOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNewWorkOrder.Glyph")));
            this.btnNewWorkOrder.Id = 1;
            this.btnNewWorkOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNewWorkOrder.LargeGlyph")));
            this.btnNewWorkOrder.Name = "btnNewWorkOrder";
            this.btnNewWorkOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewWorkOrder_ItemClick);
            // 
            // btnEditWorkOrder
            // 
            this.btnEditWorkOrder.Caption = "Editar";
            this.btnEditWorkOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditWorkOrder.Glyph")));
            this.btnEditWorkOrder.Id = 2;
            this.btnEditWorkOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditWorkOrder.LargeGlyph")));
            this.btnEditWorkOrder.Name = "btnEditWorkOrder";
            this.btnEditWorkOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnEditWorkOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditWorkOrder_ItemClick);
            // 
            // btnDeleteWorkOrder
            // 
            this.btnDeleteWorkOrder.Caption = "Eliminar";
            this.btnDeleteWorkOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteWorkOrder.Glyph")));
            this.btnDeleteWorkOrder.Id = 3;
            this.btnDeleteWorkOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteWorkOrder.LargeGlyph")));
            this.btnDeleteWorkOrder.Name = "btnDeleteWorkOrder";
            this.btnDeleteWorkOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDeleteWorkOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteWorkOrder_ItemClick);
            // 
            // btnFinalizeWorkOrder
            // 
            this.btnFinalizeWorkOrder.Caption = "Finalizar Orden de Trabajo";
            this.btnFinalizeWorkOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFinalizeWorkOrder.Glyph")));
            this.btnFinalizeWorkOrder.Id = 4;
            this.btnFinalizeWorkOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFinalizeWorkOrder.LargeGlyph")));
            this.btnFinalizeWorkOrder.Name = "btnFinalizeWorkOrder";
            this.btnFinalizeWorkOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFinalizeWorkOrder_ItemClick);
            // 
            // radioButtonViewTypeOrders
            // 
            this.radioButtonViewTypeOrders.Edit = this.repositoryRadioButtonViewTypeOrders;
            this.radioButtonViewTypeOrders.EditHeight = 40;
            this.radioButtonViewTypeOrders.EditWidth = 130;
            this.radioButtonViewTypeOrders.Id = 7;
            this.radioButtonViewTypeOrders.Name = "radioButtonViewTypeOrders";
            // 
            // repositoryRadioButtonViewTypeOrders
            // 
            this.repositoryRadioButtonViewTypeOrders.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryRadioButtonViewTypeOrders.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Open", "Ordenes Abiertas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Finalized", "Ordenes Finalizadas")});
            this.repositoryRadioButtonViewTypeOrders.Name = "repositoryRadioButtonViewTypeOrders";
            this.repositoryRadioButtonViewTypeOrders.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryRadioButtonViewTypeOrders_EditValueChanging);
            // 
            // btnReOpenWorkOrder
            // 
            this.btnReOpenWorkOrder.Caption = "Re-Abrir Orden de Trabajo";
            this.btnReOpenWorkOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReOpenWorkOrder.Glyph")));
            this.btnReOpenWorkOrder.Id = 8;
            this.btnReOpenWorkOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReOpenWorkOrder.LargeGlyph")));
            this.btnReOpenWorkOrder.Name = "btnReOpenWorkOrder";
            this.btnReOpenWorkOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReOpenWorkOrder_ItemClick);
            // 
            // btnViewWorkOrder
            // 
            this.btnViewWorkOrder.Caption = "Ver";
            this.btnViewWorkOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("btnViewWorkOrder.Glyph")));
            this.btnViewWorkOrder.Id = 9;
            this.btnViewWorkOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnViewWorkOrder.LargeGlyph")));
            this.btnViewWorkOrder.Name = "btnViewWorkOrder";
            this.btnViewWorkOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnViewWorkOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewWorkOrder_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewWorkOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnViewWorkOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditWorkOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteWorkOrder);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.radioButtonViewTypeOrders);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnFinalizeWorkOrder);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReOpenWorkOrder);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // gvWorkOrderList
            // 
            this.gvWorkOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWorkOrderList.Location = new System.Drawing.Point(0, 162);
            this.gvWorkOrderList.MainView = this.gridView1;
            this.gvWorkOrderList.MenuManager = this.ribbonControl1;
            this.gvWorkOrderList.Name = "gvWorkOrderList";
            this.gvWorkOrderList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gvWorkOrderList.Size = new System.Drawing.Size(990, 466);
            this.gvWorkOrderList.TabIndex = 1;
            this.gvWorkOrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colClientName,
            this.colVehicle,
            this.colDescription,
            this.colDate,
            this.colStatus,
            this.colUser});
            this.gridView1.GridControl = this.gvWorkOrderList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 49;
            // 
            // colClientName
            // 
            this.colClientName.Caption = "Cliente";
            this.colClientName.FieldName = "FullClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 1;
            this.colClientName.Width = 217;
            // 
            // colVehicle
            // 
            this.colVehicle.Caption = "Vehiculo";
            this.colVehicle.FieldName = "VehicleDescription";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.Visible = true;
            this.colVehicle.VisibleIndex = 2;
            this.colVehicle.Width = 175;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Anotaciones / Commentarios";
            this.colDescription.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 334;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colDate
            // 
            this.colDate.Caption = "Fecha de Ingreso";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 4;
            this.colDate.Width = 116;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Estado";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 81;
            // 
            // colUser
            // 
            this.colUser.Caption = "Asignado A";
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 6;
            // 
            // frmWorkOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 628);
            this.Controls.Add(this.gvWorkOrderList);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmWorkOrderManagement";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Trabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWorkOrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryRadioButtonViewTypeOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNewWorkOrder;
        private DevExpress.XtraBars.BarButtonItem btnEditWorkOrder;
        private DevExpress.XtraBars.BarButtonItem btnDeleteWorkOrder;
        private DevExpress.XtraGrid.GridControl gvWorkOrderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnFinalizeWorkOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem radioButtonViewTypeOrders;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryRadioButtonViewTypeOrders;
        private DevExpress.XtraBars.BarButtonItem btnReOpenWorkOrder;
        private DevExpress.XtraBars.BarButtonItem btnViewWorkOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
    }
}