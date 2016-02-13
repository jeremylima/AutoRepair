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
            return DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea Eliminar el registro ? ",
                "Auto Repair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

        }

        public static DialogResult ShowFinalizeWorkOrderMessage(int orderId = 0)
        {
            var orderIdMessage = orderId == 0 ? "" : " No." + orderId;
            return DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea Finalizar la Orden" + orderIdMessage + "?. Las existencias se restaran del inventario.", "Auto Repair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static void ShowRequiereFieldsMessage(string message)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(message, "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult ShowReOpenWorkOrderMessage(int orderId = 0)
        {
            var orderIdMessage = orderId == 0 ? "" : " No." + orderId;
            return DevExpress.XtraEditors.XtraMessageBox.Show("Esta seguro que desea Re-Abrir la Orden" + orderIdMessage + "?. Las existencias se cargaran nuevamente al inventario.", "Auto Repair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public static void LoginFailure()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("Login Failure", "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public static void OldPasswordDoesNotMatch()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("La contraseña actual es incorrecta, por favor vuelva a intentar.", "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PasswordUpdated()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("La contraseña se actualizo correctamente.", "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void DuplicatedEntry()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("El registro ya existe en la base de datos, por favor verifique.", "Auto Repair", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}