using MarketBarkod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBarkod.SaleProcces
{
    class SaleMainDATA
    {

        Model.BarkodDataDataContext Erisim = new Model.BarkodDataDataContext();
        CustomerProcces.CustomerDATA CD = new CustomerProcces.CustomerDATA();



        public int SaleProcces(decimal totalPrice, int? CustomerID, double totalDiscount, byte PaymentMethod, List<OperationProduct> OperationProducts)
        {

            Sale Satis = new Sale();
            Satis.PaymentMethodSale = PaymentMethod;
            Satis.SaleDate = DateTime.Now;
            Satis.TotalDiscount = (decimal)totalDiscount;
            Satis.TotalPrice = (decimal)totalPrice;
            Satis.CustomerID = CustomerID;
            if (!CustomerID.Equals(null))
            {
                int state;
                state = CD.CustomerProccesAdd((int)CustomerID, 1, totalPrice);
                if (!(state == 1))
                {
                    CustomMessage.CustomMsg.Message("Hata oluştu müşteriye girdi yapılamadı", "Müşteri Hesap aktivitesi Hatası", CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OK);
                }
            }
            else
            {

            }

            Erisim.Sale.InsertOnSubmit(Satis);
            Erisim.SubmitChanges();
            OperationSaleProccesProduct(OperationProducts);
            return 1;
        }
        private int OperationSaleProccesProduct(List<OperationProduct> OperationProduct)
        {
            OperationProduct opeationProduct = new OperationProduct();
            foreach (var item in OperationProduct)
            {
                item.SaleProduct = (from q in Erisim.Sale
                                    orderby q.SaleID descending
                                    select q).First().SaleID;
            }
            Erisim.OperationProduct.InsertAllOnSubmit(OperationProduct);
            Erisim.SubmitChanges();
            return 1;
        }
        public IEnumerable<Sale> Sale24HoursProcces()
        {

            return (from q in Erisim.Sale
                    where q.SaleDate >= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00")) && q.SaleDate <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 23:59:59"))
                    select q);

        }
    }
}
