﻿using System;
using System.Globalization;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using DevExpress.XtraGrid.Views.Grid;

namespace AutoRepair.UI.WinForms.Forms
{
    public partial class frmEntityFinder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Type Entity { get; set; }
        public dynamic EntitySelected { get; set; }
        public IClientManagementService _clientManagementService;
        public IVehicleManagementService _vehicleManagementService;
        public IProductManagementService _productManagementService;

        public frmEntityFinder()
        {
            _clientManagementService = CompositionRoot.Resolve<IClientManagementService>();
            _vehicleManagementService = CompositionRoot.Resolve<IVehicleManagementService>();
            _productManagementService = CompositionRoot.Resolve<IProductManagementService>();
            InitializeComponent();
        }

        private void frmEntityFinder_Load(object sender, EventArgs e)
        {
            GetDataSource();
        }

        private void GetDataSource()
        {
            if (Entity == typeof (Business.Models.Client))
                gvEntityList.DataSource = _clientManagementService.GetAllClients();
            else if(Entity == typeof(Business.Models.VehicleConsult))
                gvEntityList.DataSource = _vehicleManagementService.GetAllVehicles();
            else if (Entity == typeof (Business.Models.ProductConsult))
            {
                gvEntityList.DataSource = _productManagementService.GetAllProducts();
                gridView1.Columns[0].Visible = false;
            }

            gridView1.BestFitColumns();

        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetIdValue();
        }

        private void GetIdValue()
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                EntitySelected = (gvEntityList.FocusedView as GridView).GetRow(rowHandle);
                //IdSelected = entitySelected.Id;
            }
            Close();
        }

        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {
            GetIdValue();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var currencyColumns = e.Column.FieldName == "CostPrice" || e.Column.FieldName == "SalePrice";

            if (currencyColumns && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                e.DisplayText = string.Format(CultureInfo.CurrentCulture, "{0:c}", Convert.ToDecimal(e.Value));
                
            }
        }
    }
}
