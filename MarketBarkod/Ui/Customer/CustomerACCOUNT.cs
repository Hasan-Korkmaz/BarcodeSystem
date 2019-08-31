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
    public partial class CustomerACCOUNT : UserControl
    {
        public CustomerACCOUNT()
        {
            InitializeComponent();
            proccesTYPE.ProccesList(cmbProccesType);
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
            datagridview1.Columns["RefCustomerID"].Visible = false;
        }
        CustomerConnectComponent CCC = new CustomerConnectComponent();
        GlobalComponent.ProccesTYPE proccesTYPE = new GlobalComponent.ProccesTYPE();
        int selectedMusteriID = -1;

        private void BtnOK_Click(object sender, EventArgs e)
        {
            CCC.CustomerProccesAdd(selectedMusteriID, cmbProccesType, numericMiktar);
        }

        private void Datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMusteriID = (int)datagridview1.CurrentRow.Cells["CustomerID"].Value;
            txtcustomerName.Text = datagridview1.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtcustomerSurname.Text = datagridview1.CurrentRow.Cells["CustomerSurname"].Value.ToString();
        }

        private void FindCustomer(object sender, EventArgs e)
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
    }
}
