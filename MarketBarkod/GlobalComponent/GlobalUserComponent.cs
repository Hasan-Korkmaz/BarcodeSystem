using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.GlobalComponent
{
    class GlobalUserComponent
    {
        public DataGridView DataGridViewComponent(DataGridView gridView)
        {
            gridView.AllowUserToAddRows = false;
            //Seçim Şekli--> Tam Satır Hali 
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Kolon Başlıklarını
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(27, 31, 58);
            gridView.DefaultCellStyle.BackColor = Color.Green;
            gridView.ForeColor = Color.White;
            return gridView;
        }
    }
}
