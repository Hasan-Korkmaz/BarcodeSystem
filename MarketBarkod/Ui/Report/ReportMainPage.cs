using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.Ui.Report
{
    public partial class ReportMainPage : UserControl
    {
        public ReportMainPage()
        {
            InitializeComponent();
        }

        private void SaleReport_Click(object sender, EventArgs e)
        {

        }

        private void CustomerReport_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            int? musteriID;

            musteriID = Sale.SelectCustomer.Show();
            if (!musteriID.Equals(null))
            {
                panel2.Controls.Add(new Report.ReportCustomerProcces((int)musteriID));
            }
        }

       
    }
}
