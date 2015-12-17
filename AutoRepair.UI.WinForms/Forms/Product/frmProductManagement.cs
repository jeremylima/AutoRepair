using System;
using System.Windows.Forms;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using DevExpress.XtraGrid.Views.Grid;
using AutoRepair.UI.WinForms.Commons;

namespace AutoRepair.UI.WinForms.Forms.Product
{
    public partial class frmProductManagement : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IProductManagementService _productManagementService;

        public frmProductManagement()
        {
            _productManagementService = CompositionRoot.Resolve<IProductManagementService>();
            InitializeComponent();
        }

        private void btnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var product = new frmProduct();
            product.ShowDialog();

            LoadProducts();
        }

        private void LoadProducts()
        {
            var productList = _productManagementService.GetAllProducts();
            gvProductList.DataSource = productList;
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnEditProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var product = (Business.Models.ProductConsult)(gvProductList.FocusedView as GridView).GetRow(rowHandle);

                var frmProduct = new frmProduct { _product = _productManagementService.GetProduct(product.Id) };
                frmProduct.ShowDialog();
                LoadProducts();
            }
        }

        private void btnDeleteProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;

            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                var product = (Business.Models.ProductConsult)(gvProductList.FocusedView as GridView).GetRow(rowHandle);

                if (Notifier.ShowDeleteConfirmationMessage() == DialogResult.Yes)
                {
                    _productManagementService.Delete(_productManagementService.GetProduct(product.Id));
                    LoadProducts();
                }
            }
        }
    }
}
