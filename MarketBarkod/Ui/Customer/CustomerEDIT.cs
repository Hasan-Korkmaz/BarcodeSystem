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
    public partial class CustomerEDIT : UserControl
    {
        public CustomerEDIT()
        {
            InitializeComponent();
            CCC.cmboboxReferansDoldur(cmbcustomerReference);
            CCC.musteriListe(datagridview1);
            datagridview1.Columns["CustomerName"].HeaderText = "İsim";
            datagridview1.Columns["CustomerSurname"].HeaderText = "Soyisim";
            datagridview1.Columns["CustomerAccount"].HeaderText = "Bakiyes";
            datagridview1.Columns["CustomerTelephone"].HeaderText = "Telefon";
            datagridview1.Columns["CustomerDetails"].HeaderText = "Detaylar";
            datagridview1.Columns["CustomerAddress"].HeaderText = "Adres";
            datagridview1.Columns["CustomerOccupotion"].HeaderText = "Meslek";
            datagridview1.Columns["CustomerRegistrationDate"].HeaderText = "KayıtTarihi";
            datagridview1.Columns["RefCustomerName"].HeaderText = "Referansının Adi";
            datagridview1.Columns["RefCustomerSurname"].HeaderText = "Referansının Soyadi";
            datagridview1.Columns["CustomerID"].Visible = false;
           

            datagridview1.Columns["CustomerReference"].Visible = false;
        }
        CustomerConnectComponent CCC = new CustomerConnectComponent();

        private void BtncustomerEdit_Click(object sender, EventArgs e)
        {
            CCC = new CustomerConnectComponent();
            CCC.musteriDuzenleControl((int)datagridview1.CurrentRow.Cells["CustomerID"].Value, txtcustomerName, txtCustomerSurname, txtcustomerTelephone, txtcustomerOccupotion, cmbcustomerReference, txtcustomerAccount, rctxtcustomerAddress, rctxtcustomerDetails);
            CCC.musteriListe(datagridview1);
            CCC.cmboboxReferansDoldur(cmbcustomerReference);
            foreach (var item in this.groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tx = (TextBox)item;
                    tx.Clear();
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)item;
                    num.Value = 0;
                }
                else if (item is RichTextBox)
                {
                    RichTextBox rx = (RichTextBox)item;
                    rx.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox ms = (MaskedTextBox)item;
                    ms.Clear();

                }
            }
        }

        private void BtncustomerDelete_Click(object sender, EventArgs e)
        {
            CCC.musteriSilControl((int)datagridview1.CurrentRow.Cells["CustomerID"].Value);
            CCC.musteriListe(datagridview1);
        }

        private void CustomerFind(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtisimSearch.Text) && String.IsNullOrEmpty(txtSoyisimSearch.Text)))
            {
                this.datagridview1 = CCC.musteriListe(datagridview1);
            }
            //isim Var soyisim Yok ise
            else if (!String.IsNullOrEmpty(txtisimSearch.Text) && String.IsNullOrEmpty(txtSoyisimSearch.Text))
            {
                datagridview1 = CCC.isimMusteriListe(datagridview1, txtisimSearch);
            }
            //soyisim Var isim Yok ise
            else if (String.IsNullOrEmpty(txtisimSearch.Text) && !String.IsNullOrEmpty(txtSoyisimSearch.Text))
            {
                datagridview1 = CCC.soyisimMusteriListe(datagridview1, txtSoyisimSearch);
            }
            //İkiside Dolu ise
            else if (!(String.IsNullOrEmpty(txtisimSearch.Text) && String.IsNullOrEmpty(txtSoyisimSearch.Text)))
            {
                datagridview1 = CCC.isimvesoyisimMusteriListe(datagridview1, txtisimSearch, txtSoyisimSearch);
            }
        }

        private void Datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int refid = (int)datagridview1.CurrentRow.Cells["RefCustomerID"].Value;
            cmbcustomerReference.SelectedValue = refid;

            txtcustomerName.Text = datagridview1.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtCustomerSurname.Text = datagridview1.CurrentRow.Cells["CustomerSurname"].Value.ToString();
            txtcustomerTelephone.Text = datagridview1.CurrentRow.Cells["CustomerTelephone"].Value.ToString();
            txtcustomerOccupotion.Text = datagridview1.CurrentRow.Cells["CustomerOccupotion"].Value.ToString();
            rctxtcustomerAddress.Text = datagridview1.CurrentRow.Cells["CustomerAddress"].Value.ToString();
            rctxtcustomerDetails.Text = datagridview1.CurrentRow.Cells["CustomerDetails"].Value.ToString();
            txtcustomerAccount.Text = datagridview1.CurrentRow.Cells["CustomerAccount"].Value.ToString();
        }
    }
}
