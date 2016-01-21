using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;

namespace AutoRepair.UI.WinForms.Forms.WorkOrder
{
    public partial class frmWorkOrder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Business.Models.WorkOrder _workOrder { get; set; }
        public WorkOrderBinding _workOrderBinding { get; set; }
        public IClientManagementService _clientManagementService;
        public IVehicleManagementService _vehicleManagementService;
        public IWorkOrderManagementService _workOrderManagementService;

        public Business.Models.Vehicle _vehicle;
        public Business.Models.Client _client;

        public frmWorkOrder()
        {
            _workOrderBinding = new WorkOrderBinding();
            _clientManagementService = CompositionRoot.Resolve<IClientManagementService>();
            _vehicleManagementService = CompositionRoot.Resolve<IVehicleManagementService>();
            _workOrderManagementService = CompositionRoot.Resolve<IWorkOrderManagementService>();

            InitializeComponent();
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationProducts;
            var detailsConsult = AutoMapper.Mapper.Map<IList<WorkOrderDetail>, IList<WorkOrderDetailConsult>>(_workOrder.WorkOrderDetails);
            _workOrderBinding.ServiceCosts = new BindingList<ServiceCost>(_workOrder.ServiceCosts);
            _workOrderBinding.WorkOrderDetails = new BindingList<WorkOrderDetailConsult>(detailsConsult);

            if (_workOrder != null)
            {
                //_serviceCosts = new BindingList<ServiceCost>(_workOrder.ServiceCosts);
                
                LoadClient(_workOrder.Client.Id);
                LoadVehicle(_workOrder.Vehicle.Id);
                LoadStatus(_workOrder.Status);
                lbOrderId.Text = _workOrder.Id.ToString();
                dateEdit.EditValue = _workOrder.Date;
                txtDescription.Text = _workOrder.Description;
                LoadDetails();
                LoadServiceCosts();
                UpdateTotal();
                
            }
            else
            {
                lbOrderId.Text = "New";
                dateEdit.EditValue = DateTime.Now.Date;
                LoadStatus();
            }


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

        private void LoadStatus(string statusSelected = "")
        {
            var workOrderStatus = Utils.GetWorkOrderStatus();
            ComponentFiller.FillLookUpEdit(cmbStatus).Data(workOrderStatus, "Name", "Name", statusSelected);

        }


        private void gvClient_DoubleClick(object sender, EventArgs e)
        {
            var finder = new frmEntityFinder {Entity = typeof (Business.Models.Client)};
            finder.ShowDialog();

            if(finder.IdSelected!=0)
                LoadClient(finder.IdSelected);
        }

        private void gvVehicle_DoubleClick(object sender, EventArgs e)
        {
            var finder = new frmEntityFinder { Entity = typeof(VehicleConsult) };
            finder.ShowDialog();

            if (finder.IdSelected != 0)
                LoadVehicle(finder.IdSelected);
        }

        private void LoadClient(int clientId = 0)
        {
            var clientList = new List<Business.Models.Client>();

            if (clientId != 0)
            {
                _client = _clientManagementService.GetClient(clientId);
                clientList.Add(_client);
                gvClient.DataSource = clientList;
                return;
            }

            gvClient.DataSource = clientList;
        }

        private void LoadVehicle(int vehicleId = 0)
        {
            var vehicleList = new List<Business.Models.VehicleConsult> ();

            if (vehicleId != 0)
            {
                _vehicle = _vehicleManagementService.GetVehicle(vehicleId);
                vehicleList.Add(_vehicleManagementService.GetVehicleConsult(vehicleId));
                gvVehicle.DataSource = vehicleList;
                return;
            }

            gvVehicle.DataSource = vehicleList;
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
            if (_workOrder != null)
            {
                _workOrder.Client = _client;
                _workOrder.Vehicle = _vehicle;
                _workOrder.Date = (DateTime) dateEdit.EditValue;
                _workOrder.Description = txtDescription.Text;
                _workOrder.Status = cmbStatus.Text;

                var ss = new List<ServiceCost>();

                foreach (var serviceCost in _workOrderBinding.ServiceCosts)
                {
                    ss.Add(new ServiceCost
                    {
                        WorkOrder = _workOrder,
                        Cost = serviceCost.Cost,
                        Description = serviceCost.Description
                    });
                }

                _workOrder.ServiceCosts = ss;

                _workOrderManagementService.Update(_workOrder);
            }
        }

        private void viewDetails_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            UpdateTotal();
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            barDetails.Visible = e.Page == tabNavigationProducts;
        }

        private void btnAddProductToDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var finder = new frmEntityFinder
            {
                Entity = typeof (ProductConsult),
                WindowState = FormWindowState.Maximized
            };
            finder.ShowDialog();

            //if (finder.IdSelected != 0)
                //LoadVehicle(finder.IdSelected);
        }
    }
}
