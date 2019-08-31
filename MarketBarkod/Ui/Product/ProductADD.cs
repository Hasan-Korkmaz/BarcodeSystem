using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketBarkod.ProductProcces;

namespace MarketBarkod.Ui.Product
{
    public partial class ProductADD : UserControl
    {
        public ProductADD()
        {
            InitializeComponent();
            PCC.KategoriListesi(cmbProductCategory);
        }
        ProductConnectComponent PCC = new ProductConnectComponent();
        private void BtnProductADD_Click(object sender, EventArgs e)
        {
            PCC.UrunEkle(txtProductBarcode, txtProductName, cmbProductCategory, rctxtProductDetails, NumericSatisFiyat);

        }

        private void TxtProductBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtProductBarcode.Text.Length == 14)
            {
                txtProductBarcode.Clear();
            }
        }
    }
}
