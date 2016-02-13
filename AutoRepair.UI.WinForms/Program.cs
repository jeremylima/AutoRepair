using System;
using System.Windows.Forms;
using AutoRepair.Business.Mappings;
using AutoRepair.UI.Ninject;
using AutoRepair.UI.WinForms.Commons;
using AutoRepair.UI.WinForms.Forms.Login;

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


            var frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.User != null)
            {
                Helper.User = frmLogin.User;
                Application.Run(new Menu());
            }
            else
            {
                Application.Exit();
            }

            //Application.Run(CompositionRoot.Resolve<frmLogin>());

        }
    }
}
