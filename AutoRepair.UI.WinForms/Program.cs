using System;
using System.Windows.Forms;
using AutoRepair.Business.Mappings;
using AutoRepair.UI.Ninject;

namespace AutoRepair.UI.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            CompositionRoot.Wire(new ApplicationModule());
            Mapper.CreateMaps();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<Menu>());

        }
    }
}
