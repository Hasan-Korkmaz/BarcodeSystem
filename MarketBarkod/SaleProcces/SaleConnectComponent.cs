using CustomMessage;
using MarketBarkod.Model;
using MarketBarkod.Ui.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.SaleProcces
{
    class SaleConnectComponent
    {
        SaleMainDATA SMD;
        double totalFiyat = 0;
        double productDiscount = 0;
        string urunAdi = "null";
        decimal? urunFiyat = 0;
        bool totaleIndirimYapildimi;
        double totalDiscount = 0;
        byte islemtipi = 0;
        double waitTotalDiscount = 0;
        bool waitTotaleIndirimYapildimi;
        List<DataGridViewRow> WaitList;






        ProductProcces.ProductDATA prc = new ProductProcces.ProductDATA();
        Products item = new Products();
        public double GetToplamFiyat { get { return totalFiyat; } }
        public string GeturunAdi { get { return urunAdi; } }
        public decimal? GeturunFiyat { get { return urunFiyat; } }
        private Products UrunBul(TextBox searchproduct)
        {
            if (!String.IsNullOrEmpty(searchproduct.Text))
            {
                item = prc.UrunAra(searchproduct.Text);
                if (item != null)
                {
                    if ((item != null) && (item.ProductPiece == null) || (item.ProductPiece <= 0))
                    {

                        CustomMessage.CustomMsg.MessageResult result = CustomMessage.CustomMsg.Message(item.ProductBarcode + " Barkodlu " + item.ProductName + " Adli Ürün Ürün Stokta Olmadığı için Stoktatan Çıkış Yapılamıyor.Ürün Sayısı :" + item.ProductPiece + "\n" +
                                       "Elinizde Bu Ürün Varsa ve işlemin Devam Etmesinide İstiyorsanız Onay Verin.\n" +
                                       "Stokta bu ürün 0 ın Altına Düşecek.\nBu İşlemi Onaylıyormusunuz?", "Depoda Ürün Yok İşlem Bekleniyor", CustomMessage.CustomMsg.MessageIcon.Information, CustomMessage.CustomMsg.MessageButton.YesNo);
                        if (result.Equals(CustomMessage.CustomMsg.MessageResult.Yes))
                        {
                            return item;
                        }
                    }
                    else
                    {
                        return item;
                    }
                }

            }
            return null;

        }
        public int DataGridvieweEkle(DataGridView gridView, TextBox searchproduct)
        {
            if (!String.IsNullOrEmpty(searchproduct.Text))
            {
                item = new Products();
                item = UrunBul(searchproduct);
                if (null != item)
                {
                    gridView.Rows.Add(item.ProductID, item.ProductName, item.Categories.CategoryName, item.ProductSalePrice + "  TL", item.ProductDescription, "0 TL");
                    totalFiyat += (double)item.ProductSalePrice;
                    urunAdi = item.ProductName;
                    urunFiyat = item.ProductSalePrice;
                    return 1;
                }
            }
            return 0;
        }
        public int DataGridviewdenSil(DataGridView gridView, DataGridViewSelectedRowCollection selectedRow)
        {
            if (selectedRow.Count == 1)
            {
                totalFiyat -= double.Parse(selectedRow[0].Cells["ProductSalePrice"].Value.ToString().Split()[0]);
                gridView.Rows.Remove(selectedRow[0]);
                return 1;
            }
            else
            {
                CustomMsg.Message("Satır seçilmemiş gibi görünüyor...\nYeniden Deneyiniz...", "Null Reference", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OKCancel);
                return 0;
            }
        }
        public int ToplamIskontoYap(DataGridView gridView)
        {
            if (gridView.RowCount == 0)
            {
                CustomMessage.CustomMsg.Message("İndirim Yapabilmek için Önce Birkaç Veriye Sahip Olmalısınız.\n" +
                    "Listede Veri Yok", "Datagridviewde Veri Tespit Edilemedi"
                    , CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OKCancel);
                return 0;
            }
            else
            {
                if (totaleIndirimYapildimi == false)
                {
                    totalDiscount = (double)Discount.Show();
                    if (totalDiscount > totalFiyat)
                    {
                        CustomMessage.CustomMsg.Message("Eğer Bu İndirimi Yaparsanız Sizin Müşteriye Para Ödemeniz Lazım.\nNe Yaptığınızın Farkındamısınız Siz ?\nYaptığınız İndirim Toplam Tutarı Aşıyor !\nİşlem İptal Edildi", "Girdiler Yanlış Hata Oluştu", CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OKCancel);
                    }
                    else
                    {
                        totalFiyat = totalFiyat - totalDiscount;
                        totaleIndirimYapildimi = true;
                        return 1;
                    }
                }
                else
                {
                    CustomMessage.CustomMsg.MessageResult result = CustomMessage.CustomMsg.Message("Zaten Toplam Tutara Bir İndirim Yapıldı.\nTekrar Bir İndirim Yapacaksanız Toplam Tutar İlk Haline Çevirilecektir !\nYeniden İndirim Yapmak İstiyormusunuz ?", "İndirim Tekrar Yeniden Yapılsın mı ?", CustomMessage.CustomMsg.MessageIcon.Information, CustomMessage.CustomMsg.MessageButton.YesNo);
                    if (result == CustomMessage.CustomMsg.MessageResult.Yes)
                    {
                        totalFiyat = totalFiyat + totalDiscount;
                        totaleIndirimYapildimi = false;
                        CustomMessage.CustomMsg.Message("Toplam Tutar İlk Hale Geri Getirildi ! \nYeniden İndirim Yapabilirsiniz.", "Yeniden Düzenlendi", CustomMessage.CustomMsg.MessageIcon.OK, CustomMessage.CustomMsg.MessageButton.OKCancel);
                    }
                    else if (result == CustomMessage.CustomMsg.MessageResult.No)
                    {
                        CustomMessage.CustomMsg.Message("Yeniden İndirim Yapılması Kullanıcı Tarafından Reddedildi.", "Yeniden İndirim Yapılmadı", CustomMessage.CustomMsg.MessageIcon.Information, CustomMessage.CustomMsg.MessageButton.OKCancel);
                    }

                }
                return 0;
            }
        }
        public int UrunIskonto(DataGridView gridView, DataGridViewSelectedRowCollection selectedRow)
        {
            if (selectedRow.Count == 1)
            {

                productDiscount = (double)Discount.Show();
                if (productDiscount > double.Parse(selectedRow[0].Cells["ProductSalePrice"].Value.ToString().Split()[0]))
                {
                    CustomMessage.CustomMsg.Message("Bu ürüne yapılan indirim fiyatını aşıyor.\nİşlem İptal Edildi", "Girdiler Yanlış Hata Oluştu", CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OKCancel);
                    return 0;
                }
                else
                {

                    totalFiyat -= productDiscount;

                    gridView.CurrentRow.Cells["ProductDiscount"].Value = ((double.Parse(gridView.CurrentRow.Cells["ProductDiscount"].Value.ToString().Split(' ')[0]) + (double)productDiscount)) + " TL";
                    return 1;
                }
            }
            else
            {
                CustomMsg.Message("Satır seçilmemiş gibi görünüyor...\nYeniden Deneyiniz...", "Null Reference", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OKCancel);
                return 0;
            }
        }
        public int Iptal(DataGridView gridView)
        {
            totalFiyat = 0;
            productDiscount = 0;
            urunAdi = "null";
            urunFiyat = 0;
            totaleIndirimYapildimi = false;
            totalDiscount = 0;
            gridView.Rows.Clear();
            return 1;
        }
        public int WaitStart(DataGridView gridView)
        {
            WaitList = new List<DataGridViewRow>();
            if (gridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in gridView.Rows)
                {
                    WaitList.Add(item);
                }
                waitTotaleIndirimYapildimi = totaleIndirimYapildimi;
                waitTotalDiscount = totalDiscount;
                Iptal(gridView);
                return 1;
            }
            else if (gridView.Rows.Count == 0)
            {
                CustomMessage.CustomMsg.Message("Liste Boş.Bir ürünün Beklemeye alınabilmesi için listede veri olması gerekiyor.\n", "Boş Liste Hatası", CustomMsg.MessageIcon.Information, CustomMsg.MessageButton.OKCancel);
                return 0;
            }

            return 0;

        }
        public int WaitStop(DataGridView gridView)
        {
            Iptal(gridView);
            foreach (DataGridViewRow item in WaitList)
            {
                gridView.Rows.Add(item);
                totalFiyat += double.Parse(item.Cells["ProductSalePrice"].Value.ToString().Split(' ')[0]);
                totalFiyat -= double.Parse(item.Cells["ProductDiscount"].Value.ToString().Split(' ')[0]);
            }
            totalDiscount = waitTotalDiscount;
            totaleIndirimYapildimi = waitTotaleIndirimYapildimi;
            totalFiyat -= totalDiscount;
            waitTotalDiscount = 0;

            return 1;
        }
        public int SaleProccesFinish(object SatisTipi, DataGridView gridView)
        {
            if (gridView.Rows.Count > 0)
            {
                //Satışta Ürün var işlem yap
                int? musteriID = null;
                SMD = new SaleMainDATA();
                List<OperationProduct> OperationProduct = new List<OperationProduct>();

                List<int?> OperationProductID = new List<int?>();
                if (((Button)(SatisTipi)).Tag.Equals("Nakit"))
                {
                    //SubtboPaymentMethod 1
                    islemtipi = 1;
                }
                else if (((Button)(SatisTipi)).Tag.Equals("Kredi"))
                {
                    //SubtboPaymentMethod 2
                    islemtipi = 2;
                }
                else if (((Button)(SatisTipi)).Tag.Equals("Musteri"))
                {
                    //SubtboPaymentMethod 3
                    islemtipi = 3;
                    musteriID = Ui.Sale.SelectCustomer.Show();
                    //Kayıtlı Müşteri Butonuna Tıklanmış ama Listeden Müşteri Seçimi Yapılmayıp İptal Edilmiş
                    if (musteriID.Equals(null))
                    {
                        CustomMessage.CustomMsg.Message("Müşteri seçimi yapılmadığı için işlem iptal edildi.\nYeniden deneyiniz...\nMüşteri seçin veya farklı bir satış yöntemi deneyin.", "Satış işlmei iptal edildi", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OKCancel);
                        return -3;
                    }
                }
                else
                {
                    CustomMessage.CustomMsg.Message("İşlem tipi hatası oluştu.", "Satış işlmei iptal edildi", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OKCancel);
                    return -1;
                }
                foreach (DataGridViewRow item in gridView.Rows)
                {
                    OperationProduct.Add(new OperationProduct
                    {
                        ProductID = int.Parse(item.Cells["ProductID"].Value.ToString()),
                        ProductDiscount = decimal.Parse(item.Cells["ProductDiscount"].Value.ToString().Split()[0]),
                        ProductPrice = decimal.Parse(item.Cells["ProductSalePrice"].Value.ToString().Split()[0])
                    });
                }
                SMD.SaleProcces((decimal)GetToplamFiyat, musteriID, totalDiscount, islemtipi, OperationProduct);
                Iptal(gridView);
            }
            else
            {
                CustomMessage.CustomMsg.Message("Satışta ürün yok liste boş.\nListeyi tekrar kontrol edin.", "Satış işlmei iptal edildi", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OKCancel);
            }
            return 1;
        }
    }
}
