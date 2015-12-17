using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoRepair.Business.Mappings;
using AutoRepair.UI.Ninject;

namespace AutoRepair.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CompositionRoot.Wire(new ApplicationModule());
            Mapper.CreateMaps();
            Current.MainWindow = CompositionRoot.Resolve<MainWindow>();
            Current.MainWindow.Show();

        }
    }
}
