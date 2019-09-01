using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.Ui.Sale
{
    public partial class SelectCustomer : Form
    {
        private static int? selectedid = null;
        static SelectCustomer sc;
        CustomerProcces.CustomerConnectComponent CCC = new CustomerProcces.CustomerConnectComponent();
        public SelectCustomer()
        {
            InitializeComponent();
           
            CCC.musteriListe(customerDataGridView);
            customerDataGridView.Columns["CustomerName"].HeaderText = "İsim";
            customerDataGridView.Columns["CustomerSurname"].HeaderText = "Soyisim";
            customerDataGridView.Columns["CustomerAccount"].HeaderText = "Bakiyes";
            customerDataGridView.Columns["CustomerTelephone"].HeaderText = "Telefon";
            customerDataGridView.Columns["CustomerDetails"].HeaderText = "Detaylar";
            customerDataGridView.Columns["CustomerAddress"].HeaderText = "Adres";
            customerDataGridView.Columns["CustomerOccupotion"].HeaderText = "Meslek";
            customerDataGridView.Columns["CustomerRegistrationDate"].HeaderText = "KayıtTarihi";
            customerDataGridView.Columns["RefCustomerName"].HeaderText = "Referansının Adi";
            customerDataGridView.Columns["RefCustomerSurname"].HeaderText = "Referansının Soyadi";
            customerDataGridView.Columns["CustomerID"].Visible = false;
            customerDataGridView.Columns["CustomerReference"].Visible = false;
            customerDataGridView.Columns["RefCustomerID"].Visible = false;
        }
        public static int? Show()
        {
            sc = new SelectCustomer();
            sc.ShowDialog();
            return selectedid;
        }

        private void BtnUygula_Click(object sender, EventArgs e)
        {
            if (selectedid == -1)
            {
                CustomMessage.CustomMsg.Message("Satış Yapılacak Müşteri Seçilmedi.\nYeniden Deneyin .", "Müşteri Seçim Ekranında Hata Oluştu !", CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OK);
            }
            else
            {
                selectedid = (int)customerDataGridView.CurrentRow.Cells["CustomerID"].Value;
                sc.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            selectedid = null;
            sc.Close();
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = (int?)customerDataGridView.CurrentRow.Cells["CustomerID"].Value;
        }

        private void FinCustomer(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(txtisimSearch.Text) && String.IsNullOrEmpty(txtSoyisimSearch.Text)))
            {
                this.customerDataGridView = CCC.musteriListe(customerDataGridView);
            }
            //isim Var soyisim Yok ise
            else if (!String.IsNullOrEmpty(txtisimSearch.Text) && String.IsNullOrEmpty(txtSoyisimSearch.Text))
            {
                customerDataGridView = CCC.isimMusteriListe(customerDataGridView, txtisimSearch);
            }
            //soyisim Var isim Yok ise
            else if (String.IsNullOrEmpty(txtisimSearch.Text) && !String.IsNullOrEmpty(txtSoyisimSearch.Text))
            {
                customerDataGridView = CCC.soyisimMusteriListe(customerDataGridView, txtSoyisimSearch);
            }
            //İkiside Dolu ise
            else if (!(String.IsNullOrEmpty(txtisimSearch.Text) && String.IsNullOrEmpty(txtSoyisimSearch.Text)))
            {
                customerDataGridView = CCC.isimvesoyisimMusteriListe(customerDataGridView, txtisimSearch, txtSoyisimSearch);
            }
        }
    }
}
