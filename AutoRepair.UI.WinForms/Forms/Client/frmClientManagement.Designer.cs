namespace AutoRepair.UI.WinForms.Forms.Client
{
    partial class frmClientManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientManagement));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteClient = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvClientList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNewClient,
            this.btnEditClient,
            this.btnDeleteClient});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(943, 162);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Caption = "Nuevo";
            this.btnNewClient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNewClient.Glyph")));
            this.btnNewClient.Id = 1;
            this.btnNewClient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNewClient.LargeGlyph")));
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewClient_ItemClick);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Caption = "Editar";
            this.btnEditClient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditClient.Glyph")));
            this.btnEditClient.Id = 2;
            this.btnEditClient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditClient.LargeGlyph")));
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnEditClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditClient_ItemClick);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Caption = "Eliminar";
            this.btnDeleteClient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Glyph")));
            this.btnDeleteClient.Id = 3;
            this.btnDeleteClient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.LargeGlyph")));
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDeleteClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteClient_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewClient);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditClient);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteClient);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gvClientList
            // 
            this.gvClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvClientList.Location = new System.Drawing.Point(0, 162);
            this.gvClientList.MainView = this.gridView1;
            this.gvClientList.MenuManager = this.ribbonControl1;
            this.gvClientList.Name = "gvClientList";
            this.gvClientList.Size = new System.Drawing.Size(943, 424);
            this.gvClientList.TabIndex = 1;
            this.gvClientList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvClientList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 586);
            this.Controls.Add(this.gvClientList);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmClientManagement";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnNewClient;
        private DevExpress.XtraBars.BarButtonItem btnEditClient;
        private DevExpress.XtraBars.BarButtonItem btnDeleteClient;
        private DevExpress.XtraGrid.GridControl gvClientList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}