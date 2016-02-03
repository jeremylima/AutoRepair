namespace AutoRepair.UI.WinForms.Forms.CrudBase
{
    partial class frmEntityManagementBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntityManagementBase));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewEntity = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditEntity = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteEntity = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvEntities = new DevExpress.XtraGrid.GridControl();
            this.viewEntities = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEntities)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::AutoRepair.UI.WinForms.Properties.Resources.logo;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNewEntity,
            this.btnEditEntity,
            this.btnDeleteEntity});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(768, 162);
            // 
            // btnNewEntity
            // 
            this.btnNewEntity.Caption = "Nuevo";
            this.btnNewEntity.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNewEntity.Glyph")));
            this.btnNewEntity.Id = 1;
            this.btnNewEntity.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNewEntity.LargeGlyph")));
            this.btnNewEntity.Name = "btnNewEntity";
            this.btnNewEntity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewEntity_ItemClick);
            // 
            // btnEditEntity
            // 
            this.btnEditEntity.Caption = "Editar";
            this.btnEditEntity.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditEntity.Glyph")));
            this.btnEditEntity.Id = 2;
            this.btnEditEntity.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditEntity.LargeGlyph")));
            this.btnEditEntity.Name = "btnEditEntity";
            this.btnEditEntity.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnEditEntity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditEntity_ItemClick);
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.Caption = "Eliminar";
            this.btnDeleteEntity.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteEntity.Glyph")));
            this.btnDeleteEntity.Id = 3;
            this.btnDeleteEntity.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeleteEntity.LargeGlyph")));
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDeleteEntity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteEntity_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewEntity);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditEntity);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteEntity);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gvEntities
            // 
            this.gvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEntities.Location = new System.Drawing.Point(0, 162);
            this.gvEntities.MainView = this.viewEntities;
            this.gvEntities.MenuManager = this.ribbonControl1;
            this.gvEntities.Name = "gvEntities";
            this.gvEntities.Size = new System.Drawing.Size(768, 397);
            this.gvEntities.TabIndex = 1;
            this.gvEntities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewEntities});
            // 
            // viewEntities
            // 
            this.viewEntities.GridControl = this.gvEntities;
            this.viewEntities.Name = "viewEntities";
            this.viewEntities.OptionsView.ShowAutoFilterRow = true;
            // 
            // frmEntityManagementBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 559);
            this.Controls.Add(this.gvEntities);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmEntityManagementBase";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntityManagementBase";
            this.Load += new System.EventHandler(this.frmEntityManagementBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEntities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.BarButtonItem btnNewEntity;
        public DevExpress.XtraBars.BarButtonItem btnEditEntity;
        public DevExpress.XtraBars.BarButtonItem btnDeleteEntity;
        public DevExpress.XtraGrid.GridControl gvEntities;
        public DevExpress.XtraGrid.Views.Grid.GridView viewEntities;
    }
}