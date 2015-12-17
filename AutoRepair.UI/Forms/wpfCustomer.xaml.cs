using System.Windows;
using AutoRepair.Business.Services;
using AutoRepair.UI.Ninject;

namespace AutoRepair.UI.Forms
{
    /// <summary>
    /// Interaction logic for wpfCustomer.xaml
    /// </summary>
    public partial class wpfCustomer : Window
    {
        public IClientManagementService ClientService;

        public wpfCustomer()
        {
            ClientService = CompositionRoot.Resolve<IClientManagementService>();
            InitializeComponent();
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
