using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.MainStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(sender.ToString()+"   "+e.KeyChar);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "..\\..\\..\\DATA\\BarcodeSystem.mdf");
        }
    }
}
