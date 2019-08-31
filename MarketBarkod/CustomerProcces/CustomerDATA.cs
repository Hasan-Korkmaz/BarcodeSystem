using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketBarkod.Model;

namespace MarketBarkod.CustomerProcces
{
    class CustomerDATA
    {   //TODO:Silinen Müşteri False Olcak
        //TODO:AYnı Müşteri iki kez Eklenemez 
        BarkodDataDataContext Erisim = new BarkodDataDataContext();
        Customers cust = new Customers();
        Model.CustomerProcces procces;
        public int MusteriEkleProc(string musteriadi, string musterisoyadi, string telefon, string meslegi, int referans, string bakiye, string adres, string detay)
        {
            try
            {
                Customers cust = new Customers();
                cust.CustomerName = musteriadi;
                cust.CustomerSurname = musterisoyadi;
                cust.CustomerTelephone = telefon;
                cust.CustomerOccupotion = meslegi;
                cust.CustomerReference = (int)referans;
                cust.CustomerAccount = Convert.ToDecimal(bakiye);
                cust.CustomerAddress = adres;
                cust.CustomerDetails = detay;
                cust.CustomerRegistrationDate = DateTime.Now;
                cust.isActive = true;
                Erisim.Customers.InsertOnSubmit(cust);
                Erisim.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {

                CustomMessage.CustomMsg.Message(e.Message.ToString(), "Hata", CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OK);
                return -1;
            }


        }
        public int MusteriSil(int mID)
        {
            if (!MusteriIDyeGöreAra(mID).Equals(null))
            {
                cust = new Customers();
                cust = MusteriIDyeGöreAra(mID);
                cust.isActive = false;
                Erisim.SubmitChanges();
                return 1;
            }
            else
            {
                return -1;
            }


        }
        public int MusteriDuzenle(Customers cust, RefCustomer copycust, string musteriadi, string musterisoyadi, string telefon, string meslegi, int refid, decimal bakiye, string adres, string detay)
        {
            try
            {
                cust.CustomerName = musteriadi;
                cust.CustomerSurname = musterisoyadi;
                cust.CustomerTelephone = telefon;
                cust.CustomerOccupotion = meslegi;
                cust.CustomerAddress = adres;
                cust.CustomerDetails = detay;
                cust.CustomerAccount = bakiye;
                cust.CustomerReference = refid;
                copycust.RefCustomerName = musteriadi;
                copycust.RefCustomerSurname = musterisoyadi;

                Erisim.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }


        }
        public IQueryable MusteriListesi()
        {
            var q = (from cust in Erisim.Customers
                     where cust.isActive == true
                     orderby cust.CustomerName
                     select new
                     {
                         cust.CustomerID,
                         cust.CustomerName,
                         cust.CustomerSurname,
                         cust.CustomerTelephone,
                         cust.CustomerAddress,
                         cust.CustomerDetails,
                         cust.CustomerAccount,
                         cust.CustomerOccupotion,
                         cust.CustomerReference,
                         cust.CustomerRegistrationDate,
                         cust.RefCustomer.RefCustomerID,
                         cust.RefCustomer.RefCustomerName,
                         cust.RefCustomer.RefCustomerSurname
                     });
            return q;

        }
        public IQueryable IsmeGoreListe(string adi)
        {
            IQueryable q = (from cust in Erisim.Customers
                            orderby cust.CustomerName
                            where cust.CustomerName.StartsWith(adi) && cust.isActive == true
                            select new
                            {
                                cust.CustomerID,
                                cust.CustomerName,
                                cust.CustomerSurname,
                                cust.CustomerTelephone,
                                cust.CustomerAddress,
                                cust.CustomerDetails,
                                cust.CustomerAccount,
                                cust.CustomerOccupotion,
                                cust.CustomerReference,
                                cust.CustomerRegistrationDate,
                                cust.RefCustomer.RefCustomerName,
                                cust.RefCustomer.RefCustomerSurname
                            }) ;;
            return q;
        }
        public IQueryable SoyisimeGoreListe(string soyad)
        {

            IQueryable q = (from cust in Erisim.Customers
                            orderby cust.CustomerName
                            where cust.CustomerSurname.StartsWith(soyad) && cust.isActive == true
                            select new
                            {
                                cust.CustomerID,
                                cust.CustomerName,
                                cust.CustomerSurname,
                                cust.CustomerTelephone,
                                cust.CustomerAddress,
                                cust.CustomerDetails,
                                cust.CustomerAccount,
                                cust.CustomerOccupotion,
                                cust.CustomerReference,
                                cust.CustomerRegistrationDate,
                                cust.RefCustomer.RefCustomerName,
                                cust.RefCustomer.RefCustomerSurname
                            });
            return q;
        }
        public IQueryable IsimVeSoyisimeGoreListe(string ad, string soyad)
        {
            IQueryable q = (from cust in Erisim.Customers
                            orderby cust.CustomerName
                            where cust.CustomerName.StartsWith(ad) && cust.CustomerSurname.StartsWith(soyad) && cust.isActive == true
                            select new
                            {
                                cust.CustomerID,
                                cust.CustomerName,
                                cust.CustomerSurname,
                                cust.CustomerTelephone,
                                cust.CustomerAddress,
                                cust.CustomerDetails,
                                cust.CustomerAccount,
                                cust.CustomerOccupotion,
                                cust.CustomerReference,
                                cust.CustomerRegistrationDate,
                                cust.RefCustomer.RefCustomerName,
                                cust.RefCustomer.RefCustomerSurname
                            });
            return q;
        }
        public List<Customers> MusteriListesiLinked()
        {
            List<Customers> musteriler = new List<Customers>();
            musteriler = (from cust in Erisim.Customers where cust.isActive == true select cust).ToList();

            return musteriler;
        }
        public Customers MusteriIDyeGöreAra(int mID)
        {
            cust = (from q in Erisim.Customers
                    where q.CustomerID == mID && q.isActive == true
                    select q).First();
            return cust;

        }
        public RefCustomer ReferansAra(int refID)
        {
            var copycust = (from r in Erisim.RefCustomer
                            where r.RefCustomerID == refID
                            select
                                r).First();
            return copycust;

        }
        public Dictionary<int, string> ReferanslarListesi()
        {
            Dictionary<int, string> referanslar = new Dictionary<int, string>();
            var sorgu = from ReferansListe in Erisim.RefCustomer
                        select new
                        {
                            ReferansListe.RefCustomerID,
                            ReferansListe.RefCustomerName,
                            ReferansListe.RefCustomerSurname
                        };
            foreach (var item in sorgu)
            {
                referanslar.Add(item.RefCustomerID, item.RefCustomerName + " " + item.RefCustomerSurname);
            }
            return referanslar;
        }
        public int CustomerProccesAdd(int mID, int proccesType, decimal proccesPrice)
        {
            try
            {
                procces = new Model.CustomerProcces();
                cust = new Customers();
                cust = MusteriIDyeGöreAra(mID);
                if (!cust.Equals(null))
                {
                    cust.CustomerAccount = cust.CustomerAccount - proccesPrice;
                    procces.CustomerID = mID;
                    procces.ProccesType = proccesType;
                    procces.ProccesPrice = proccesPrice;
                    procces.ProccesDate = DateTime.Now;
                    Erisim.CustomerProcces.InsertOnSubmit(procces);
                    Erisim.SubmitChanges();
                    return 1;
                }
                else
                {

                    return -1;
                }
            }
            catch (Exception)
            {

                return -1;
            }
        }
        public IEnumerable<OperationProduct> musteriProductDokum(int? musteriID, DateTime start, DateTime stop)
        {
            var data = from q in Erisim.OperationProduct
                       where q.Sale.CustomerID == musteriID && q.Sale.SaleDate >= start && q.Sale.SaleDate <= stop
                       select q;

            return data;
        }
        public IEnumerable<Model.CustomerProcces> musteriOdemedokum(int? musteriID, DateTime start, DateTime stop)
        {
            var data = from q in Erisim.CustomerProcces
                       where q.Customers.CustomerID == musteriID && q.ProccesDate >= start && q.ProccesDate <= stop
                       select q;

            return data;
        }

    }
}
