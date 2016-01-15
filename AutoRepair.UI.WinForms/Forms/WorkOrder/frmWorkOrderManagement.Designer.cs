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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvWorkOrderList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnDeleteWorkOrder});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewWorkOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditWorkOrder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteWorkOrder);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gvWorkOrderList
            // 
            this.gvWorkOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWorkOrderList.Location = new System.Drawing.Point(0, 162);
            this.gvWorkOrderList.MainView = this.gridView1;
            this.gvWorkOrderList.MenuManager = this.ribbonControl1;
            this.gvWorkOrderList.Name = "gvWorkOrderList";
            this.gvWorkOrderList.Size = new System.Drawing.Size(990, 466);
            this.gvWorkOrderList.TabIndex = 1;
            this.gvWorkOrderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvWorkOrderList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
    }
}