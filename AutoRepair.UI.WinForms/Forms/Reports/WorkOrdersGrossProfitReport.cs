using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace AutoRepair.UI.WinForms.Forms.Reports
{
    public partial class WorkOrdersGrossProfitReport : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sumProducts;
        private decimal sumServices;
        public WorkOrdersGrossProfitReport()
        {
            InitializeComponent();
        }

        private void xrLabelSumProducts_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            sumProducts = Convert.ToDecimal(e.Value);
        }

        private void xrLabelSumServices_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            sumServices = Convert.ToDecimal(e.Value);
        }

        private void xrLabelSumTotal_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var total = sumProducts + sumServices;
            ((XRLabel)sender).Text = total.ToString("c2");
        }
    }
}
