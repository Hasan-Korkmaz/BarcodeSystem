using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.MainStart
{
    class MainPageRouting
    {
        public static void AddPage(UserControl uc)
        {
            Program.mainPage.pnlContainer.Controls.Clear();
            Program.mainPage.pnlContainer.Controls.Add(uc);
        }
        public static void Clear()
        {
            Program.mainPage.pnlContainer.Controls.Clear();
        }
    }
}
