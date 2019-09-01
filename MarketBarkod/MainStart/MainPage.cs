using MarketBarkod.Properties;
using MarketBarkod.Ui.Customer;
using MarketBarkod.Ui.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.MainStart
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCustomerADD_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new CustomerADD());
        }

        private void BtnCustomerEDIT_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new CustomerEDIT());
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new CustomerACCOUNT());
        }

        private void BtnProductADD_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new ProductADD());
        }

        private void BtnProductEDIT_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new ProductEDIT());
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new Ui.Sale.SaleMainPage());
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            MainPageRouting.AddPage(new Ui.Report.ReportMainPage());

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Save();
            /*
            string workingDirectory = Environment.CurrentDirectory;
            CustomMessage.CustomMsg.Message("Test");
            MessageBox.Show(Environment.CurrentDirectory);
            MessageBox.Show(Application.StartupPath);
            MessageBox.Show(Application.ExecutablePath);
            MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
            MessageBox.Show(System.IO.Directory.GetParent(workingDirectory).Parent.FullName);*/

        }

      

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void PnlContainer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }

        private void Button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }
    }
}
