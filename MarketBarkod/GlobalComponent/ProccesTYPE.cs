using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.GlobalComponent
{
    class ProccesTYPE
    {

        Model.BarkodDataDataContext Erisim = new Model.BarkodDataDataContext();
        public IQueryable ProccesList()
        {
            var q = from proc in Erisim.ProccesList select proc;
            return q;
        }

        public ComboBox ProccesList(ComboBox cmb)
        {
            Dictionary<int, string> ProccesListe = new Dictionary<int, string>();

            var sorgu = from q in Erisim.ProccesList
                        select new
                        {
                            q.ProccesID,
                            q.ProccesType
                        };
            foreach (var item in sorgu)
            {
                ProccesListe.Add(item.ProccesID, item.ProccesType);
            }
            cmb.DataSource = new BindingSource(ProccesListe, null);

            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";


            return cmb;
        }
    }

}
