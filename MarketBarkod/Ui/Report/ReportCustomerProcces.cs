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
    public partial class ReportCustomerProcces : UserControl
    {
        int musteriID;
        public ReportCustomerProcces( int musteriID)
        {
            InitializeComponent();
            this.musteriID = musteriID;
        
        }

        private void BtnBuyReport_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new CustomerBuyProcces(musteriID));
        }

        private void AccountReport_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new CustomerAccountProcces(musteriID));
        }
    }
}
