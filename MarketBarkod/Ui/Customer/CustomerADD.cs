using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketBarkod.CustomerProcces;

namespace MarketBarkod.Ui.Customer
{
    public partial class CustomerADD : UserControl
    {
        public CustomerADD()
        {
            InitializeComponent();
            CCC.cmboboxReferansDoldur(cmbCustomerRefrence);

        }
        CustomerConnectComponent CCC = new CustomerConnectComponent();
        private void BtncustomerInsert_Click(object sender, EventArgs e)
        {
            CCC.musteriEkleControl(txtcustomerName, txtSurname, txtCustomerTelephone, txtcusomerOccupotion, cmbCustomerRefrence, txtcustomerAccount, rctxtcustomerAddress, rctxtcustomerDetail);

        }
    }
}
