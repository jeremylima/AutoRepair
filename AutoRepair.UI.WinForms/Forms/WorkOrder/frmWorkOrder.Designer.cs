using System;

namespace AutoRepair.UI.WinForms.Forms.WorkOrder
{
    partial class frmWorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkOrder));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gvClient = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gvVehicle = new DevExpress.XtraGrid.GridControl();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationProducts = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gvDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationServiceCosts = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gvServiceCosts = new DevExpress.XtraGrid.GridControl();
            this.viewServiceCosts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deleteServiceCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteServiceCost = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDescriptionServiceCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostServiceCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbOrderId = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cmbStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabNavigationServiceCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServiceCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteServiceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 143);
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
            // gvClient
            // 
            this.gvClient.Location = new System.Drawing.Point(12, 212);
            this.gvClient.MainView = this.cardView1;
            this.gvClient.MenuManager = this.ribbonControl1;
            this.gvClient.Name = "gvClient";
            this.gvClient.Size = new System.Drawing.Size(218, 186);
            this.gvClient.TabIndex = 1;
            this.gvClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.gvClient.DoubleClick += new System.EventHandler(this.gvClient_DoubleClick);
            // 
            // cardView1
            // 
            this.cardView1.Appearance.FieldValue.Options.UseTextOptions = true;
            this.cardView1.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gvClient;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsView.ShowCardCaption = false;
            this.cardView1.OptionsView.ShowCardExpandButton = false;
            this.cardView1.OptionsView.ShowFieldHints = false;
            this.cardView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.cardView1.OptionsView.ShowHorzScrollBar = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.OptionsView.ShowViewCaption = true;
            this.cardView1.ViewCaption = "Cliente";
            // 
            // gvVehicle
            // 
            this.gvVehicle.Location = new System.Drawing.Point(12, 415);
            this.gvVehicle.MainView = this.cardView2;
            this.gvVehicle.MenuManager = this.ribbonControl1;
            this.gvVehicle.Name = "gvVehicle";
            this.gvVehicle.Size = new System.Drawing.Size(218, 234);
            this.gvVehicle.TabIndex = 3;
            this.gvVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView2});
            this.gvVehicle.DoubleClick += new System.EventHandler(this.gvVehicle_DoubleClick);
            // 
            // cardView2
            // 
            this.cardView2.Appearance.FieldValue.Options.UseTextOptions = true;
            this.cardView2.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
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
            this.cardView2.OptionsView.ShowViewCaption = true;
            this.cardView2.ViewCaption = "Vehiculo";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationProducts);
            this.tabPane1.Controls.Add(this.tabNavigationServiceCosts);
            this.tabPane1.Location = new System.Drawing.Point(261, 212);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationProducts,
            this.tabNavigationServiceCosts});
            this.tabPane1.RegularSize = new System.Drawing.Size(870, 445);
            this.tabPane1.SelectedPage = this.tabNavigationServiceCosts;
            this.tabPane1.SelectedPageIndex = 1;
            this.tabPane1.Size = new System.Drawing.Size(870, 445);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationProducts
            // 
            this.tabNavigationProducts.Caption = "Repuestos / Productos";
            this.tabNavigationProducts.Controls.Add(this.gvDetails);
            this.tabNavigationProducts.Name = "tabNavigationProducts";
            this.tabNavigationProducts.Size = new System.Drawing.Size(852, 400);
            // 
            // gvDetails
            // 
            this.gvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetails.Location = new System.Drawing.Point(0, 0);
            this.gvDetails.MainView = this.gridView1;
            this.gvDetails.MenuManager = this.ribbonControl1;
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.Size = new System.Drawing.Size(852, 400);
            this.gvDetails.TabIndex = 0;
            this.gvDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvDetails;
            this.gridView1.Name = "gridView1";
            // 
            // tabNavigationServiceCosts
            // 
            this.tabNavigationServiceCosts.Caption = "Mano de Obra";
            this.tabNavigationServiceCosts.Controls.Add(this.gvServiceCosts);
            this.tabNavigationServiceCosts.Name = "tabNavigationServiceCosts";
            this.tabNavigationServiceCosts.Size = new System.Drawing.Size(852, 400);
            // 
            // gvServiceCosts
            // 
            this.gvServiceCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvServiceCosts.Location = new System.Drawing.Point(0, 0);
            this.gvServiceCosts.MainView = this.viewServiceCosts;
            this.gvServiceCosts.MenuManager = this.ribbonControl1;
            this.gvServiceCosts.Name = "gvServiceCosts";
            this.gvServiceCosts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.btnDeleteServiceCost});
            this.gvServiceCosts.Size = new System.Drawing.Size(852, 400);
            this.gvServiceCosts.TabIndex = 1;
            this.gvServiceCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewServiceCosts});
            // 
            // viewServiceCosts
            // 
            this.viewServiceCosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.deleteServiceCost,
            this.colDescriptionServiceCost,
            this.colCostServiceCost});
            this.viewServiceCosts.GridControl = this.gvServiceCosts;
            this.viewServiceCosts.Name = "viewServiceCosts";
            this.viewServiceCosts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.viewServiceCosts.OptionsCustomization.AllowColumnMoving = false;
            this.viewServiceCosts.OptionsCustomization.AllowGroup = false;
            this.viewServiceCosts.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewServiceCosts.OptionsCustomization.AllowRowSizing = true;
            this.viewServiceCosts.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.viewServiceCosts.OptionsView.ShowGroupPanel = false;
            this.viewServiceCosts.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // deleteServiceCost
            // 
            this.deleteServiceCost.Caption = "Delete";
            this.deleteServiceCost.ColumnEdit = this.btnDeleteServiceCost;
            this.deleteServiceCost.Name = "deleteServiceCost";
            this.deleteServiceCost.Visible = true;
            this.deleteServiceCost.VisibleIndex = 0;
            this.deleteServiceCost.Width = 50;
            // 
            // btnDeleteServiceCost
            // 
            this.btnDeleteServiceCost.AutoHeight = false;
            this.btnDeleteServiceCost.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteServiceCost.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDeleteServiceCost.Name = "btnDeleteServiceCost";
            this.btnDeleteServiceCost.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteServiceCost.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteServiceCost_ButtonClick);
            // 
            // colDescriptionServiceCost
            // 
            this.colDescriptionServiceCost.Caption = "Description";
            this.colDescriptionServiceCost.FieldName = "Description";
            this.colDescriptionServiceCost.Name = "colDescriptionServiceCost";
            this.colDescriptionServiceCost.Visible = true;
            this.colDescriptionServiceCost.VisibleIndex = 1;
            this.colDescriptionServiceCost.Width = 594;
            // 
            // colCostServiceCost
            // 
            this.colCostServiceCost.Caption = "Cost";
            this.colCostServiceCost.ColumnEdit = this.repositoryItemTextEdit1;
            this.colCostServiceCost.FieldName = "Cost";
            this.colCostServiceCost.Name = "colCostServiceCost";
            this.colCostServiceCost.Visible = true;
            this.colCostServiceCost.VisibleIndex = 2;
            this.colCostServiceCost.Width = 190;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "c";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "c";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "c";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 680);
            this.txtDescription.MenuManager = this.ribbonControl1;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1110, 96);
            this.txtDescription.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 660);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Descripcion del Servicio / Comentarios:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Location = new System.Drawing.Point(16, 156);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 24);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "No. Orden:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(261, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Fecha:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(518, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Estado:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl5.Location = new System.Drawing.Point(787, 164);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 33);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Total:";
            // 
            // lbOrderId
            // 
            this.lbOrderId.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbOrderId.Location = new System.Drawing.Point(119, 149);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(122, 33);
            this.lbOrderId.TabIndex = 12;
            this.lbOrderId.Text = "No. Orden";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(303, 163);
            this.dateEdit.MenuManager = this.ribbonControl1;
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(163, 20);
            this.dateEdit.TabIndex = 13;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Location = new System.Drawing.Point(565, 162);
            this.cmbStatus.MenuManager = this.ribbonControl1;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStatus.Size = new System.Drawing.Size(163, 20);
            this.cmbStatus.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(863, 161);
            this.txtTotal.MenuManager = this.ribbonControl1;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.DisplayFormat.FormatString = "c";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.EditFormat.FormatString = "c";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.Mask.EditMask = "c";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(257, 40);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TabStop = false;
            // 
            // frmWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 788);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.gvVehicle);
            this.Controls.Add(this.gvClient);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmWorkOrder";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Trabajo";
            this.Load += new System.EventHandler(this.frmWorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabNavigationServiceCosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServiceCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteServiceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraGrid.GridControl gvClient;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.GridControl gvVehicle;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationProducts;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationServiceCosts;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbOrderId;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.LookUpEdit cmbStatus;
        private DevExpress.XtraGrid.GridControl gvDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gvServiceCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView viewServiceCosts;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriptionServiceCost;
        private DevExpress.XtraGrid.Columns.GridColumn colCostServiceCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn deleteServiceCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteServiceCost;
    }
}