namespace AutoRepair.UI.WinForms.Forms.Product
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvProductList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNewProduct,
            this.btnEditProduct,
            this.btnDeleteProduct});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1282, 162);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Caption = "Nuevo";
            this.btnNewProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNewProduct.Glyph")));
            this.btnNewProduct.Id = 1;
            this.btnNewProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNewProduct.LargeGlyph")));
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewProduct_ItemClick);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Caption = "Editar";
            this.btnEditProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Glyph")));
            this.btnEditProduct.Id = 2;
            this.btnEditProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.LargeGlyph")));
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditProduct_ItemClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Caption = "Eliminar";
            this.btnDeleteProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Glyph")));
            this.btnDeleteProduct.Id = 3;
            this.btnDeleteProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.LargeGlyph")));
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDeleteProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteProduct_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteProduct);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gvProductList
            // 
            this.gvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvProductList.Location = new System.Drawing.Point(0, 162);
            this.gvProductList.MainView = this.gridView1;
            this.gvProductList.MenuManager = this.ribbonControl1;
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.Size = new System.Drawing.Size(1282, 612);
            this.gvProductList.TabIndex = 2;
            this.gvProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvProductList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 774);
            this.Controls.Add(this.gvProductList);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmProductManagement";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNewProduct;
        private DevExpress.XtraBars.BarButtonItem btnEditProduct;
        private DevExpress.XtraBars.BarButtonItem btnDeleteProduct;
        private DevExpress.XtraGrid.GridControl gvProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}