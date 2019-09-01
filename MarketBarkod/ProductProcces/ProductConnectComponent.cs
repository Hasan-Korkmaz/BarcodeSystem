using CustomMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod.ProductProcces
{
    class ProductConnectComponent
    {
        ProductDATA prc = new ProductDATA();
        GlobalComponent.GlobalUserComponent userComponent;
        public int UrunEkle(TextBox Barkod, TextBox name, ComboBox KategoriID, RichTextBox description, NumericUpDown satisfiyat)
        {
            int productState = 0;
            if (String.IsNullOrEmpty(Barkod.Text) || String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(KategoriID.Text) || String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(satisfiyat.Value.ToString()) || String.IsNullOrEmpty(KategoriID.SelectedIndex.ToString()))
            {
                //Null Değer Döndü
                CustomMsg.Message("Boş girilen değerler var.\nLütfen gereken bilgileri yeniden doldurup deneyiniz.", "Null Reference", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                return -1;
            }
            else
            {

                productState = prc.UrunEkle(Barkod.Text.ToString(), name.Text.ToString(), (int)KategoriID.SelectedValue, description.Text, (decimal)satisfiyat.Value);
                if (productState == 1)
                {
                    CustomMsg.Message(Barkod.Text + " Barkodlu ürün Veritabanına Eklenmiştir", "İşlem Tamamlandı", CustomMsg.MessageIcon.OK, CustomMsg.MessageButton.OK);

                }
                else if (productState == -2)
                {
                    CustomMsg.Message(Barkod.Text + " Bu ürün zaten Veritabanında Var !\nBu ürünü silip yeniden deneyin...", "İşlem Tamamlanamadı", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                }
                return productState;
            }
        }
        public int UrunDuzenle(TextBox Barkod, TextBox name, ComboBox KategoriID, RichTextBox description, NumericUpDown satisfiyat)
        {
            if (String.IsNullOrEmpty(Barkod.Text) || String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(KategoriID.Text) || String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(satisfiyat.Value.ToString()) || String.IsNullOrEmpty(KategoriID.SelectedIndex.ToString()))
            {
                //Null Değer Döndü
                CustomMsg.Message("Boş girilen değerler var.\nLütfen gereken bilgileri yeniden doldurup deneyiniz.", "Null Reference", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                return -1;
            }
            else
            {
                try
                {
                    byte state;
                    state = (byte)prc.UrunDuzenle(Barkod.Text.ToString(), name.Text.ToString(), (int)KategoriID.SelectedValue, description.Text, (decimal)satisfiyat.Value);
                    if (state == 1)
                    {
                        CustomMsg.Message(name.Text + " Başarılı bir şekilde düzenlenmiştir", "İşlem Başarılı", CustomMsg.MessageIcon.OK, CustomMsg.MessageButton.OK);
                    }
                    else
                    {

                        CustomMsg.Message("Veritabanı Hatası...\n Konum ProductConnectComponent-UrunDuzenle", "Veri Hatası", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    }

                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }

            }
        }
        public int UrunSil(string deleteID)
        {
            if (!string.IsNullOrEmpty(deleteID))
            {
                try
                {

                    if (CustomMsg.Message("Gerçekten bu ürünü silmek istiyor musunuz ?", "Silme Yetkilendirme", CustomMsg.MessageIcon.Information, CustomMsg.MessageButton.YesNoCancel).Equals(CustomMsg.MessageResult.Yes))
                    {
                        prc.UrunSil(deleteID);
                        CustomMessage.CustomMsg.Message("Ürün başarılı bir şekilde silinmiştir", "İşlem başarılı", CustomMsg.MessageIcon.Trash, CustomMsg.MessageButton.OK);
                        return 1;
                    }
                    else
                    {
                        CustomMessage.CustomMsg.Message("Silme işlemi iptal edildi.", "Silme işlemi kullanıcı trafından kesildi.", CustomMsg.MessageIcon.OK, CustomMsg.MessageButton.OK);
                        return 1;
                    }

                }
                catch (Exception)
                {

                    CustomMsg.Message("Veritabanından silerken bir hata oluştu veriye erişilemiyor", "Silme işlemi uygulama tarafından kesildi", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    return -1;
                }
            }
            else
            {
                CustomMsg.Message("Listeden silinecek ürün seçilmemiş... \nÜrün Seçip yeniden deneyin.", "Boş Değer Döndü", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                return -1;
            }
        }
        public Model.Products UrunAra(TextBox Barkod)
        {
            if (!String.IsNullOrEmpty(Barkod.Text))
            {
                try
                {
                    return prc.UrunAra(Barkod.Text);

                }
                catch (Exception)
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }
        public IQueryable BarkodaGoreUrunListele(TextBox Barkod)
        {
            if (!String.IsNullOrEmpty(Barkod.Text))
            {
                try
                {
                    return prc.BarkodaGoreUrunListe(Barkod.Text);
                }
                catch (Exception)
                {
                    return null;
                }

            }
            else
            {
                return null;
            }

        }
        public IQueryable IsmeGoreUrunListele(TextBox ProductName)
        {
            if (!String.IsNullOrEmpty(ProductName.Text))
            {
                try
                {
                    return prc.IsmeGoreUrunListe(ProductName.Text);
                }
                catch (Exception)
                {
                    return null;
                }

            }
            else
            {
                return null;
            }

        }
        public IQueryable IsimveBarkod(TextBox Barkod, TextBox ProductName)
        {
            try
            {
                return prc.IsimeVeBarkoda(Barkod.Text, ProductName.Text);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ComboBox KategoriListesi(ComboBox cmbProductCategory)
        {

            if (prc.KategoriListesi().ToList().Count > 0)
            {
                cmbProductCategory.DataSource = prc.KategoriListesi();
                cmbProductCategory.DisplayMember = "CategoryName";
                cmbProductCategory.ValueMember = "CategoryID";
            }
            else
            {
                cmbProductCategory.DataSource = null;
                CustomMsg.Message("Kategori listesi yok kategori ekleyin", "Kategori kayıtları yok", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
            }
            return cmbProductCategory;

        }
        public DataGridView DataGridViewGenelUrunListesi(DataGridView DGV)
        {
            userComponent = new GlobalComponent.GlobalUserComponent();
            userComponent.DataGridViewComponent(DGV);
            DGV.DataSource = prc.UrunleriListele();

            return DGV;
        }

        public int StockEntry(TextBox Barkod, TextBox mikt, RichTextBox rc, NumericUpDown num)
        {
            if (String.IsNullOrEmpty(Barkod.Text) || String.IsNullOrEmpty(mikt.Text) || String.IsNullOrEmpty(rc.Text) || String.IsNullOrEmpty(num.Value.ToString()))
            {
                //Null Değer Döndü
                CustomMsg.Message("Boş girilen değerler var.\nLütfen gereken bilgileri yeniden doldurup deneyiniz.", "Null Reference", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                return -1;
            }
            else
            {
                int state;
                state = prc.StokGiris(Barkod.Text, Convert.ToInt32(mikt.Text), rc.Text, num.Value);
                if (state==1)
                {
                    CustomMsg.Message("Stoğa giriş başarılı bir şekilde tamamlandı.", "StockOK", CustomMsg.MessageIcon.OK, CustomMsg.MessageButton.OK);
                    return 1;

                }
                else if (state==-2)
                {
                    CustomMsg.Message("Bu Barkod Tanımlanmamıştır.\nLütfen Ürün Ekle Kısmından ekleyin daha sonra stok girişi yapın", "Ürün YOK", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    return -1;

                }
                else 
                {
                    CustomMsg.Message("Veritabanı Hatası Oluştu", "DB Error", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    return -1;
                }
            }
        }
    }
}
