using System;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;

namespace AutoRepair.UI.WinForms.Forms.Product
{
    public partial class frmProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.Product _product { get; set; }
        public IProductManagementService _productManagementService;
        public ICategoryManagementService _categoryManagementService;
        public IMakeManagementService _makeManagementService;

        public frmProduct()
        {
            InitializeComponent();
            _productManagementService = CompositionRoot.Resolve<IProductManagementService>();
            _categoryManagementService = CompositionRoot.Resolve<ICategoryManagementService>();
            _makeManagementService = CompositionRoot.Resolve<IMakeManagementService>();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (_product != null)
            {
                LoadCategories(_product.Category.Id);
                LoadMakes(_product.Make.Id);
                txtCode.Text = _product.Code;
                txtName.Text = _product.Name;
                txtDescription.Text = _product.Description;
                txtCostPrice.Text = _product.CostPrice.ToString();
                txtSalePrice.Text = _product.SalePrice.ToString();
                txtStock.Text = _product.Stock.ToString();

            }
            else
            {
                LoadCategories();
                LoadMakes();
            }
                
        }

        private void LoadMakes(int makeSelected = 0)
        {
            var makes = _makeManagementService.GetAllMakes();
            ComponentFiller.FillLookUpEdit(cmbMake).Data(makes, "Name", "Id", makeSelected);
        }

        private void LoadCategories(int categorySelected = 0)
        {
            var categories = _categoryManagementService.GetAllCategories();
            ComponentFiller.FillLookUpEdit(cmbCaterory).Data(categories, "Name", "Id", categorySelected);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_product != null)
            {
                _product.Code = txtCode.Text;
                _product.Name = txtName.Text;
                _product.Description = txtDescription.Text;
                _product.CostPrice = Convert.ToDecimal(txtCostPrice.Text);
                _product.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
                _product.Stock = Convert.ToDecimal(txtStock.Text);
                _product.Category = _categoryManagementService.GetCategory((int) cmbCaterory.EditValue);
                _product.Make = _makeManagementService.GetMake((int) cmbMake.EditValue);

                _productManagementService.Update(_product);

                Notifier.ShowEditSuccessMessage();

            }
            else
            {
                _productManagementService.Add(new Business.Models.Product
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    CostPrice = Convert.ToDecimal(txtCostPrice.Text),
                    SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                    Stock = Convert.ToDecimal(txtStock.Text),
                    Category = _categoryManagementService.GetCategory((int) cmbCaterory.EditValue),
                    Make = _makeManagementService.GetMake((int) cmbMake.EditValue)
                });

                Notifier.ShowAddSuccessMessage();
            }

            Close();
        }
       
    }
}
