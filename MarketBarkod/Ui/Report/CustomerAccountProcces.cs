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
    public partial class CustomerAccountProcces : UserControl
    {
        int musteriID;
        public CustomerAccountProcces( int musteriID)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void CustomerReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ab");
        }
    }
}
