using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.Ui.Sale
{
    public partial class SaleMainPage : UserControl
    {
        public SaleMainPage()
        {
            GlobalComponent.GlobalUserComponent GlobalCom = new GlobalComponent.GlobalUserComponent();
            InitializeComponent();
            dataGridView1.Columns.Add("ProductID", "ProductID");
            dataGridView1.Columns.Add("ProductName", "Ürün Adı");
            dataGridView1.Columns.Add("CategoryName", "Kategori Adı");
            dataGridView1.Columns.Add("ProductSalePrice", "Satış Fiyat");
            dataGridView1.Columns.Add("ProductDescription", "Açıklama");
            dataGridView1.Columns.Add("ProductDiscount", "Ürün İndirimi");
            dataGridView1.Columns["ProductID"].Visible = false;
            GlobalCom.DataGridViewComponent(dataGridView1);
        }
        SaleProcces.SaleConnectComponent SCC = new SaleProcces.SaleConnectComponent();
        string selectedProductID;
        int state = 0;
        char[] charsToTrim = { '\n', '\r' };
        private void TxtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBarcodeSearch.Text.Contains('\n') || txtBarcodeSearch.Text.Contains('\r'))
            {
                txtBarcodeSearch.Text = txtBarcodeSearch.Text.TrimEnd(charsToTrim);
                state = SCC.DataGridvieweEkle(dataGridView1, txtBarcodeSearch);
                txtBarcodeSearch.Clear();

            }
            
            if (state == 1)
            {
                button10.BackColor = Color.Green;
                lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
                lblName.Text = "Ürün Adı : " + SCC.GeturunAdi;
                lblPrice.Text = "Ürün Fiyat : " + SCC.GeturunFiyat.ToString() + " TL";
            }
            else
            {
                button10.BackColor = Color.Red;
            }
            txtBarcodeSearch.Focus();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProductID = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SCC.DataGridviewdenSil(dataGridView1, dataGridView1.SelectedRows);
            lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
            txtBarcodeSearch.Focus();
        }

        private void BtnTotaliskonto_Click(object sender, EventArgs e)
        {
            SCC.ToplamIskontoYap(dataGridView1);
            txtBarcodeSearch.Focus();
            lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
            txtBarcodeSearch.Focus();
        }

        private void BtnProductDiscount_Click(object sender, EventArgs e)
        {
            SCC.UrunIskonto(dataGridView1, dataGridView1.SelectedRows);
            lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
            txtBarcodeSearch.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SCC.Iptal(dataGridView1);
            lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
            lblName.Text = "Ürün Adı : " + SCC.GeturunAdi;
            lblPrice.Text = "Ürün Fiyat : " + SCC.GeturunFiyat.ToString() + " TL";
            txtBarcodeSearch.Focus();
        }

        private void BtnWaitList_Click(object sender, EventArgs e)
        {
            int state = 0;
            state = SCC.WaitStart(dataGridView1);
            if (state == 1)
            {
                btnWaitList.Visible = false;
                btnWaitListReturn.Visible = true;
                lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
                lblName.Text = "Ürün Adı : " + SCC.GeturunAdi;
                lblPrice.Text = "Ürün Fiyat : " + SCC.GeturunFiyat.ToString() + " TL";
            }
            txtBarcodeSearch.Focus();

        }

        private void BtnWaitListReturn_Click(object sender, EventArgs e)
        {
            int state = 0;
            state = SCC.WaitStop(dataGridView1);
            if (state == 1)
            {
                btnWaitListReturn.Visible = false;
                btnWaitList.Visible = true;
                lblTotal.Text = "Toplam Tutar :" + SCC.GetToplamFiyat.ToString() + "TL";
                lblName.Text = "Ürün Adı : " + SCC.GeturunAdi;
                lblPrice.Text = "Ürün Fiyat : " + SCC.GeturunFiyat.ToString() + " TL";
            }
            txtBarcodeSearch.Focus();
        }

        private void ProccesFinish(object sender, EventArgs e)
        {
            SCC.SaleProccesFinish(sender, dataGridView1);
            txtBarcodeSearch.Focus();
        }

        private void SaleMainPage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void TxtBarcodeSearch_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
