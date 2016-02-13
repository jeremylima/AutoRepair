using System.Windows.Forms;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;

namespace AutoRepair.UI.WinForms.Commons
{
    public class Validator
    {
        public static void Validate(Control.ControlCollection controlCollection)
        {
            foreach (Control ctrl in controlCollection)
            {
                BaseEdit edit = ctrl as BaseEdit;
                if (edit != null)
                {
                    edit.IsModified = true;
                    edit.DoValidate();
                }
            }
        }
    }
}