using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoRepair.Business.Models;
using AutoRepair.Business.Services;
using AutoRepair.UI.Forms;
using AutoRepair.UI.Ninject;

namespace AutoRepair.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IClientManagementService ClientService;

        public MainWindow()
        {
            ClientService = CompositionRoot.Resolve<IClientManagementService>();

            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var wCustomer = new wpfCustomer();
            wCustomer.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var allCustomer = ClientService.GetAllClients();

            //var wCustomerList = new wpfGenericList(new List<object>(allCustomer));
            //wCustomerList.ShowDialog();
        }
    }

    public interface IMainWindow
    {
        void Show();
    }
}
