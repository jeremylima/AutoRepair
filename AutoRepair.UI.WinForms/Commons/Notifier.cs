using System.Windows.Forms;

namespace AutoRepair.UI.WinForms.Commons
{
    public class Notifier
    {
        public static void ShowAddSuccessMessage()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("Registro Guardado Exitosamente! ", "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowEditSuccessMessage()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("Registro Editado Exitosamente!", "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowDeleteConfirmationMessage()
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea Eliminar el registro ? ", "Auto Repair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

    }
}