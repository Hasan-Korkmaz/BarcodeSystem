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
    public partial class ProductEDIT : UserControl
    {
        ProductConnectComponent PCC = new ProductConnectComponent();
        string selectedproductBarkod;
        public ProductEDIT()
        {
            
            InitializeComponent();
            this.datagridview1 = PCC.DataGridViewGenelUrunListesi(datagridview1);
            PCC.KategoriListesi(cmbProductCategory);
            datagridview1.Columns["ProductBarcode"].HeaderText = "Barkod";
            datagridview1.Columns["ProductName"].HeaderText = "İsim";
            datagridview1.Columns["ProductSalePrice"].HeaderText = "Satış Fiyat";
            datagridview1.Columns["ProductDescription"].HeaderText = "Açıklama";
            datagridview1.Columns["CategoryName"].HeaderText = "Kategorisi";
            datagridview1.Columns["ProductID"].Visible = false;
            datagridview1.Columns["CategoryID"].Visible = false;
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtSearchBarkod.Focus();
        }

        private void BtnProductEDIT_Click(object sender, EventArgs e)
        {
            PCC.UrunDuzenle(txtProductBarcode, txtProductName, cmbProductCategory, rctxtProductDetails, NumericSatisFiyat);
            PCC.DataGridViewGenelUrunListesi(datagridview1);
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        char[] charsToTrim = { '\n', '\r' };
        private void FindProduct(object sender, EventArgs e)
       {
            if ((String.IsNullOrEmpty(txtSearchBarkod.Text) && String.IsNullOrEmpty(txtSearchName.Text)))
            {
                this.datagridview1 = PCC.DataGridViewGenelUrunListesi(datagridview1);
            }
            //Barkod Var İsim Yok ise
            else if (!String.IsNullOrEmpty(txtSearchBarkod.Text) && String.IsNullOrEmpty(txtSearchName.Text))
            {
               
                if (txtSearchBarkod.Text.Contains('\n') || txtSearchBarkod.Text.Contains('\r'))
                {
                    txtSearchBarkod.Text = txtSearchBarkod.Text.TrimEnd(charsToTrim);
                    datagridview1.DataSource = PCC.BarkodaGoreUrunListele(txtSearchBarkod);
                    if (datagridview1.RowCount ==1)
                    {
                        selectedproductBarkod = datagridview1.Rows[0].Cells["ProductBarcode"].Value.ToString();
                        txtProductBarcode.Text = datagridview1.Rows[0].Cells["ProductBarcode"].Value.ToString();
                        txtProductName.Text = datagridview1.Rows[0].Cells["ProductName"].Value.ToString();
                        NumericSatisFiyat.Value = Convert.ToDecimal(datagridview1.Rows[0].Cells["ProductSalePrice"].Value);
                        rctxtProductDetails.Text = datagridview1.Rows[0].Cells["ProductDescription"].Value.ToString();
                        cmbProductCategory.SelectedValue = (int)datagridview1.Rows[0].Cells["CategoryID"].Value;
                    }
                }
                
            }
            //İsim Var Barkod Yok ise
            else if (String.IsNullOrEmpty(txtSearchBarkod.Text) && !String.IsNullOrEmpty(txtSearchName.Text))
            {
                datagridview1.DataSource = PCC.IsmeGoreUrunListele(txtSearchName);
            }
            //İkiside Dolu ise
            else if (!(String.IsNullOrEmpty(txtSearchBarkod.Text) && String.IsNullOrEmpty(txtSearchName.Text)))
            {
                datagridview1.DataSource = PCC.IsimveBarkod(txtSearchBarkod, txtSearchName);
            }
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedproductBarkod = datagridview1.CurrentRow.Cells["ProductBarcode"].Value.ToString();
            txtProductBarcode.Text = datagridview1.CurrentRow.Cells["ProductBarcode"].Value.ToString();
            txtProductName.Text = datagridview1.CurrentRow.Cells["ProductName"].Value.ToString();
            NumericSatisFiyat.Value = Convert.ToDecimal(datagridview1.CurrentRow.Cells["ProductSalePrice"].Value);
            rctxtProductDetails.Text = datagridview1.CurrentRow.Cells["ProductDescription"].Value.ToString();
            cmbProductCategory.SelectedValue = (int)datagridview1.CurrentRow.Cells["CategoryID"].Value;
        }

        private void BtnProductDELETE_Click(object sender, EventArgs e)
        {
            PCC.UrunSil(datagridview1.CurrentRow.Cells["ProductBarcode"].Value.ToString());
            PCC.DataGridViewGenelUrunListesi(datagridview1);
            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void ProductEDIT_Load(object sender, EventArgs e)
        {
            txtSearchBarkod.Focus();
        }
    }
}
