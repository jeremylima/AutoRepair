using System;

namespace AutoRepair.UI.WinForms.Forms.CrudBase
{
    public partial class frmEntityBase : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmEntityBase(string formTitle)
        {
            InitializeComponent();
            Text = formTitle;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public virtual void frmEntityBase_Load(object sender, EventArgs e)
        {

        }

        public virtual void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
