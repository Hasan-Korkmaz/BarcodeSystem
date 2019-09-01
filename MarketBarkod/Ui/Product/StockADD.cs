using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.Ui.Product
{
    public partial class StockADD : UserControl
    {
        public StockADD()
        {
            InitializeComponent();
        }

        private void StockADD_Load(object sender, EventArgs e)
        {
            txtProductBarcode.Focus();
        }
        ProductProcces.ProductConnectComponent pcc = new ProductProcces.ProductConnectComponent();
        private void BtnEntry_Click(object sender, EventArgs e)
        {
            int state = 0;
            state=pcc.StockEntry(txtProductBarcode, Miktar, rcManufacturer, NumericFiyat);
            if (state==-1)
            {
                txtProductBarcode.Clear();
                Miktar.Clear();
                NumericFiyat.Value = 0;
                rcManufacturer.Clear();
                txtProductBarcode.Focus();
            }
        }

        private void TxtProductBarcode_TextChanged(object sender, EventArgs e)
        {
            char[] charsToTrim = { '\n', '\r' };
            if (txtProductBarcode.Text.Contains('\n') || txtProductBarcode.Text.Contains('\r'))
            {
                txtProductBarcode.Text = txtProductBarcode.Text.TrimEnd(charsToTrim);
            }
        }
    }
}
