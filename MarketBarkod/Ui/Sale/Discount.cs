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
    public partial class Discount : Form
    {
        static Discount dsc;
        public Discount()
        {
            InitializeComponent();
        }
        static decimal discount = 0;
        public static decimal Show()
        {
            dsc = new Discount();
            dsc.ShowDialog();
            return discount;
        }


        private void BtnUygula_Click(object sender, EventArgs e)
        {
            discount = Convert.ToDecimal(txtDiscount.Text);
            dsc.Close();
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            discount = 0;
            dsc.Close();
        }
    }
}
