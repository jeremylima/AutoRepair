using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepair.UI.WinForms.Forms.CrudBase
{
    public partial class frmEntityManagementBase : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmEntityManagementBase(string formTitle)
        {
            InitializeComponent();
            Text = formTitle;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public virtual void frmEntityManagementBase_Load(object sender, EventArgs e)
        {

        }

        public virtual void btnNewEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnEditEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnDeleteEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
