using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.DataAccess.Entities;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using ServiceCost = AutoRepair.Business.Models.ServiceCost;
using WorkOrderDetail = AutoRepair.Business.Models.WorkOrderDetail;

namespace AutoRepair.UI.WinForms.Forms.WorkOrder
{
    public partial class frmWorkOrder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.WorkOrder _workOrder { get; set; }
        public bool FinalizeWorkOrder { get; set; }
        public bool IsViewAction { get; set; }
        public WorkOrderBinding _workOrderBinding { get; set; }
        public IClientManagementService _clientManagementService;
        public IVehicleManagementService _vehicleManagementService;
        public IWorkOrderManagementService _workOrderManagementService;
        public IProductManagementService _productManagementService;
        public IUserManagementService _userManagementService;

        public int _vehicleId;
        public Business.Models.Client _client;
        public ProductConsult _product;

        public frmWorkOrder()
        {
            _workOrderBinding = new WorkOrderBinding();
            _clientManagementService = CompositionRoot.Resolve<IClientManagementService>();
            _vehicleManagementService = CompositionRoot.Resolve<IVehicleManagementService>();
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();
            _productManagementService = CompositionRoot.Resolve<IProductManagementService>();
            _userManagementService = CompositionRoot.Resolve<IUserManagementService>();

            InitializeComponent();
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            LoadInitValues();

            if (_workOrder != null)
            {
                var detailsConsult = AutoMapper.Mapper.Map<IList<WorkOrderDetail>, IList<WorkOrderDetailConsult>>(_workOrder.WorkOrderDetails);
                _workOrderBinding.ServiceCosts = new BindingList<ServiceCost>(_workOrder.ServiceCosts);
                _workOrderBinding.WorkOrderDetails = new BindingList<WorkOrderDetailConsult>(detailsConsult);
                LoadClient(_workOrder.Client);
                LoadVehicle(AutoMapper.Mapper.Map<Business.Models.Vehicle, VehicleConsult>(_workOrder.Vehicle));
                LoadUser(_workOrder.User.Id);
                LoadStatus(_workOrder.Status);
                lbOrderId.Text = _workOrder.Id.ToString();
                dateEditEntryDate.EditValue = _workOrder.Date;
                dateEditLeaveDate.EditValue = _workOrder.FinalizedDate;
                txtDescription.Text = _workOrder.Description;
                
            }
            else
            {
                _workOrderBinding.ServiceCosts = new BindingList<ServiceCost>();
                _workOrderBinding.WorkOrderDetails = new BindingList<WorkOrderDetailConsult>();

                lbOrderId.Text = @"New";
                dateEditEntryDate.EditValue = DateTime.Now.Date;
                LoadStatus();
                LoadUser();
            }

            LoadDetails();
            LoadServiceCosts();
            UpdateTotal();
        }

        private void LoadInitValues()
        {
            if (IsViewAction)
            {
                btnSave.Enabled = false;
                btnSaveAndFinalize.Enabled = false;
                barDetails.Visible = false;
                viewServiceCosts.OptionsView.NewItemRowPosition= NewItemRowPosition.None;
                deleteServiceCost.Visible = false;
                deleteDetail.Visible = false;
                viewServiceCosts.OptionsBehavior.Editable = false;
                viewDetails.OptionsBehavior.Editable = false;
                cmbUser.Properties.ReadOnly = true;
                dateEditEntryDate.Properties.Enabled = false;

            }

            tabPane1.SelectedPage = tabNavigationProducts;

        }

        public void UpdateTotal()
        {
            txtTotal.Text = _workOrderBinding.Total.ToString();
        }

        private void LoadServiceCosts()
        {
            gvServiceCosts.DataSource = _workOrderBinding.ServiceCosts;
        }

        private void LoadDetails()
        {
            gvDetails.DataSource = _workOrderBinding.WorkOrderDetails;

        }

        private void LoadStatus(WorkOrderStatus statusSelected = WorkOrderStatus.Open)
        {
            cmbStatus.Properties.DataSource = Enum.GetNames(typeof(WorkOrderStatus));
            cmbStatus.EditValue = statusSelected.ToString();
        }

        private void LoadUser(int userSelected = 0)
        {
            var users = _userManagementService.GetAllActiveUsers().Select(models => new { models.Id, models.Name });
            ComponentFiller.FillLookUpEdit(cmbUser).Data(users, "Name", "Id", userSelected);
        }

        private void gvClient_DoubleClick(object sender, EventArgs e)
        {
            if(IsViewAction)
                return;

            var finder = new frmEntityFinder {Entity = typeof (Business.Models.Client)};
            finder.ShowDialog();

            if(finder.EntitySelected!=null)
                LoadClient(finder.EntitySelected);
        }

        private void gvVehicle_DoubleClick(object sender, EventArgs e)
        {
            if (IsViewAction)
                return;

            var finder = new frmEntityFinder { Entity = typeof(VehicleConsult) };
            finder.ShowDialog();

            if (finder.EntitySelected != null)
                LoadVehicle(finder.EntitySelected);
        }

        private void LoadClient(Business.Models.Client client)
        {
            if (client != null)
            {
                _client = client;
                gvClient.DataSource = new List<Business.Models.Client> {client};
            }
        }

        private void LoadVehicle(Business.Models.VehicleConsult vehicle)
        {
            if (vehicle != null)
            {
                _vehicleId = vehicle.Id;
                gvVehicle.DataSource = new List<VehicleConsult> { vehicle };
            }
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            UpdateTotal();
        }

        private void btnDeleteServiceCost_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            viewServiceCosts.DeleteRow(viewServiceCosts.FocusedRowHandle);
            UpdateTotal();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(FormValidated))
            {
                Notifier.ShowRequiereFieldsMessage(FormValidated);
                return;
            }

            SaveOrUpdateWorkOrder();
            Notifier.ShowAddSuccessMessage();
            Close();
        }

        private void SaveOrUpdateWorkOrder(bool finalized = false)
        {
            if (_workOrder != null)
            {
                _workOrder.Client = _client;
                _workOrder.Vehicle = _vehicleManagementService.GetVehicle(_vehicleId);
                _workOrder.User = _userManagementService.GetUser((int)cmbUser.EditValue);
                _workOrder.Date = (DateTime) dateEditEntryDate.EditValue;
                _workOrder.Description = txtDescription.Text;
                _workOrder.Status = WorkOrderStatus.Open;

                _workOrder.ServiceCosts = TransformServiceCostsBinding();
                _workOrder.WorkOrderDetails = TransformDetailsBinding();

                _workOrderManagementService.Update(_workOrder, finalized);
            }
            else
            {
                _workOrderManagementService.Add(new Business.Models.WorkOrder
                {
                    Client = _client,
                    Vehicle = _vehicleManagementService.GetVehicle(_vehicleId),
                    User = _userManagementService.GetUser((int)cmbUser.EditValue),
                    Date = (DateTime) dateEditEntryDate.EditValue,
                    Description = txtDescription.Text,
                    Status = WorkOrderStatus.Open,
                    ServiceCosts = TransformServiceCostsBinding(),
                    WorkOrderDetails = TransformDetailsBinding()
                }, finalized);
            }
        }

        public string FormValidated
        {
            get
            {
                if (_client == null)
                    return "Por favor seleccione un cliente.";

                if(_vehicleId == 0)
                    return "Por favor seleccione un vehiculo.";

                if (!(viewDetails.RowCount > 0) && !(viewServiceCosts.RowCount > 0))
                    return "Por favor ingrese productos o servicios a la order.";

                if(cmbUser.EditValue == null)
                    return "Por favor asigne la orden a un empleado.";

                return string.Empty;
            }
        }

        private IList<WorkOrderDetail> TransformDetailsBinding()
        {
            return _workOrderBinding.WorkOrderDetails.Select(workOrderDetail => new WorkOrderDetail
            {
                WorkOrder = _workOrder ?? new Business.Models.WorkOrder(),
                Product = _productManagementService.GetProduct(workOrderDetail.Id),
                CostPrice = workOrderDetail.CostPrice,
                SalePrice = workOrderDetail.SalePrice,
                Quantity = workOrderDetail.Quantity
            }).ToList();

        }

        private IList<ServiceCost> TransformServiceCostsBinding()
        {
            return _workOrderBinding.ServiceCosts.Select(serviceCost => new ServiceCost
            {
                WorkOrder = _workOrder ?? new Business.Models.WorkOrder(),
                Cost = serviceCost.Cost,
                Description = serviceCost.Description
            }).ToList();
        }

        private void viewDetails_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            UpdateTotal();
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            barDetails.Visible = e.Page == tabNavigationProducts && !IsViewAction;
        }

        private void btnAddProductToDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var finder = new frmEntityFinder
            {
                Entity = typeof (ProductConsult),
                WindowState = FormWindowState.Maximized
            };
            finder.ShowDialog();

            if (finder.EntitySelected != null)
            {
                _product = finder.EntitySelected;
                viewDetails.AddNewRow();
                viewDetails.FocusedColumn = viewDetails.VisibleColumns[4];
                viewDetails.ShowEditor();
            }

        }

        private void viewDetails_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            viewDetails.SetRowCellValue(e.RowHandle, "Id", _product.Id);
            viewDetails.SetRowCellValue(e.RowHandle, "Code",_product.Code);
            viewDetails.SetRowCellValue(e.RowHandle, "Product", _product.Description);
            viewDetails.SetRowCellValue(e.RowHandle, "CostPrice", _product.CostPrice);
            viewDetails.SetRowCellValue(e.RowHandle, "SalePrice", _product.SalePrice);
            viewDetails.SetRowCellValue(e.RowHandle, "Quantity", 1);

        }

        private void btnDeleteDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            viewDetails.DeleteRow(viewDetails.FocusedRowHandle);
            UpdateTotal();
        }

        private void btnSaveAndFinalize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(FormValidated))
            {
                Notifier.ShowRequiereFieldsMessage(FormValidated);
                return;
            }

            if (Notifier.ShowFinalizeWorkOrderMessage() == DialogResult.Yes)
            {
                SaveOrUpdateWorkOrder(true);
                Notifier.ShowAddSuccessMessage();
                Close();
            }
        }
    }
}
