using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessage;
using MarketBarkod.Model;

namespace MarketBarkod.CustomerProcces
{
    
        class CustomerConnectComponent
        {
            CustomerDATA customProc = new CustomerDATA();
            Customers cust = new Customers();
            GlobalComponent.GlobalUserComponent GlobalUserComponent = new GlobalComponent.GlobalUserComponent();
            DataGridView datagridprops = new DataGridView();
            public int musteriEkleControl(TextBox txname, TextBox txsoyisim, MaskedTextBox txtel, TextBox txmeslek, ComboBox cmbreferans, NumericUpDown txbakiye, RichTextBox adres, RichTextBox detay)
            {

                if (cmbreferans.SelectedValue == null)
                {
                    CustomMsg.Message("Referans Kısmında Hata Oluştu...\n" +
                        "Muhtemelen Açılır Listede Olmayan Bir Referans Seçtiniz...\n" +
                        "Lütfen Açılır Listeden Referansi Doğru Şekilde Seçiniz...\n" +
                        "Eğer Referans Seçmiyecekseniz Referans Bölümüne 1 Yazmanız Yeterlidir", "Referans Seçim Bloğunda Hata Oluştu", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    return -1;

                }
                else if (cmbreferans.Text == "1" &&
                    string.IsNullOrWhiteSpace(txname.Text) != true &&
                    string.IsNullOrWhiteSpace(txsoyisim.Text) != true)
                {
                    customProc = new CustomerDATA();
                    customProc.MusteriEkleProc(txname.Text, txsoyisim.Text, txtel.Text, txmeslek.Text, (int)cmbreferans.SelectedValue, txbakiye.Text, adres.Text, detay.Text);
                    CustomMessage.CustomMsg.Message(txname.Text + " " + txsoyisim.Text + "\n" +
                                    "Adli Müşteri Kaydedildi",
                                    "Müsteri Kayıt İşlemi Başarılı", CustomMessage.CustomMsg.MessageIcon.Information
                                    , CustomMessage.CustomMsg.MessageButton.OK);
                }
                else if (string.IsNullOrWhiteSpace(cmbreferans.Text) != true &&
                    string.IsNullOrWhiteSpace(txname.Text) != true &&
                    string.IsNullOrWhiteSpace(txsoyisim.Text) != true)
                {
                    customProc = new CustomerDATA();
                    customProc.MusteriEkleProc(txname.Text, txsoyisim.Text, txtel.Text, txmeslek.Text, (int)cmbreferans.SelectedValue, txbakiye.Text, adres.Text, detay.Text);
                    CustomMessage.CustomMsg.Message(txname.Text + " " + txsoyisim.Text + "\n" +
                                    "Adli Müşteri Kaydedildi",
                                    "Müsteri Kayıt İşlemi Başarılı", CustomMessage.CustomMsg.MessageIcon.Information
                                    , CustomMessage.CustomMsg.MessageButton.OK);
                }
                else
                {
                    CustomMsg.Message("Yeni Müşteri Ekleme Başarısız Oldu...\n" +
                        "Verileri Doğru Girdiğinizden Emin Olun", "Girdilerde Hata Oluştu", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);

                }



                return 1;
            }
            public void musteriSilControl(int mID)
            {

                //TODO:Musteri Silinince Ref Tablosunda durumu false ve combobxa dolarken true olanlar dolcak yalnızca 
                customProc = new CustomerDATA();
                cust = new Customers();
                cust = customProc.MusteriIDyeGöreAra(mID);
                if (cust.CustomerAccount > 0)
                {
                    CustomMsg.MessageResult result = CustomMsg.Message(cust.CustomerName + " " + cust.CustomerSurname + " Müsteriyi Silmek Üzeresiniz..."
                                                     + cust.CustomerName + cust.CustomerSurname + " İsmindeki Müşterinin Borç durumu: "
                                                  + cust.CustomerAccount + "\n\nYinede Silmeye Devam Edilsinmi ?",
                                                 "Silme İşlemi Yetkilendirilmesi", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.YesNoCancel);
                    if (result == CustomMsg.MessageResult.Yes)
                    {
                        CustomMsg.Message(cust.CustomerName + " " + cust.CustomerSurname + " Adindaki Müsteri Silindi", "Müsteri Silme İşlemi", CustomMsg.MessageIcon.Trash, CustomMsg.MessageButton.OK);
                        customProc.MusteriSil(mID);
                    }
                    else
                    {
                        CustomMsg.Message("Müşteri Silme İşlemi İptal Edildi..", "Müsteri Silme İşlemi", CustomMsg.MessageIcon.Information, CustomMsg.MessageButton.OK);
                    }
                }
                else
                {
                    if (CustomMsg.MessageResult.Yes.Equals(CustomMsg.Message(cust.CustomerName + " " + cust.CustomerSurname + " Müşteri silinsin mi ?", "Silme İşlemi Yetkilendirilmesi", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.YesNoCancel)))
                    {
                        CustomMsg.Message(cust.CustomerName + " " + cust.CustomerSurname + " Adindaki Müsteri Silindi", "Müsteri Silme İşlemi", CustomMsg.MessageIcon.Trash, CustomMsg.MessageButton.OK);
                    }
                    else
                    {
                        CustomMsg.Message(cust.CustomerName + " " + cust.CustomerSurname + " Adindaki Müsteri Silindi", "Müsteri Silme İşlemi", CustomMsg.MessageIcon.Trash, CustomMsg.MessageButton.OK);
                    }
                }

            }
            public void musteriDuzenleControl(int mID, TextBox txname, TextBox txsoyisim, MaskedTextBox txtel, TextBox txmeslek, ComboBox cmbreferans, NumericUpDown txbakiye, RichTextBox adres, RichTextBox detay)
            {
                customProc = new CustomerDATA();

                if (cmbreferans.SelectedValue == null)
                {
                    CustomMsg.Message("Referans Kısmında Hata Oluştu...\n" +
                        "Muhtemelen Açılır Listede Olmayan Bir Referans Seçtiniz...\n" +
                        "Lütfen Açılır Listeden Referansi Doğru Şekilde Seçiniz...\n" +
                        "Eğer Referans Seçmiyecekseniz Referans Bölümüne 1 Yazmanız Yeterlidir", "Referans Seçim Bloğunda Hata Oluştu", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);

                }
                else
                {
                    if (cmbreferans.Text == "1")
                    {
                        if (customProc.MusteriDuzenle(customProc.MusteriIDyeGöreAra(mID), customProc.ReferansAra(mID),
                            txname.Text, txsoyisim.Text, txtel.Text, txmeslek.Text, 1, Convert.ToDecimal(txbakiye.Value),
                             adres.Text, detay.Text) == 1)
                        {
                            CustomMsg.Message(txname.Text + " " + txsoyisim.Text + "\n" +
                                            "Adli Müşteri Kaydedildi",
                                            "Müsteri Düzenleme İşlemi Başarılı",
                                            CustomMsg.MessageIcon.Information,
                                            CustomMsg.MessageButton.OK);
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(cmbreferans.Text) != true &&
                        string.IsNullOrWhiteSpace(txname.Text) != true &&
                        string.IsNullOrWhiteSpace(txsoyisim.Text) != true)
                    {
                        if (customProc.MusteriDuzenle(customProc.MusteriIDyeGöreAra(mID), customProc.ReferansAra(mID),
                            txname.Text, txsoyisim.Text, txtel.Text, txmeslek.Text, (int)cmbreferans.SelectedValue, Convert.ToDecimal(txbakiye.Value),
                             adres.Text, detay.Text) == 1)
                        {
                            CustomMsg.Message(txname.Text + " " + txsoyisim.Text + "\n" +
                                            "Adli Müşteri Kaydedildi",
                                            "Müsteri Kayıt İşlemi Başarılı",
                                            CustomMsg.MessageIcon.Information,
                                            CustomMsg.MessageButton.OK);
                        }
                    }
                    else
                    {
                        CustomMsg.Message("Müşteri Düzenleme İşlemi Başarısız...\n" +
                            "Verileri Doğru Girdiğinizden Emin Olun", "Girdilerde Hata Oluştu", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    }
                }


            }
            public DataGridView musteriListe(DataGridView DGV)
            {
                DGV.DataSource = customProc.MusteriListesi();
                GlobalUserComponent.DataGridViewComponent(DGV);

                return DGV;
            }
            public DataGridView isimMusteriListe(DataGridView DGV, TextBox isim)
            {
                if (!String.IsNullOrEmpty(isim.Text))
                {
                    try
                    {
                        DGV.DataSource = customProc.IsmeGoreListe((isim.Text.ToString()));

                    }
                    catch (Exception)
                    {
                        CustomMsg.Message("Veritabanı hatasi oluştu\nKonum:CustomerConnectComponent-Musterileridoldur", "Veritabanı Bağlantısı Hatası", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    }

                }
                GlobalUserComponent.DataGridViewComponent(DGV);
                return DGV;
            }
            public DataGridView soyisimMusteriListe(DataGridView DGV, TextBox soyisim)
            {
                if (!String.IsNullOrEmpty(soyisim.Text))
                {
                    try
                    {
                        DGV.DataSource = customProc.SoyisimeGoreListe(soyisim.Text);

                    }
                    catch (Exception)
                    {
                        CustomMsg.Message("Veritabanı hatasi oluştu\nKonum:CustomerConnectComponent-Musterileridoldur", "Veritabanı Bağlantısı Hatası", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    }

                }
                GlobalUserComponent.DataGridViewComponent(DGV);

                return DGV;
            }
            public DataGridView isimvesoyisimMusteriListe(DataGridView DGV, TextBox isim, TextBox soyisim)
            {
                if (!String.IsNullOrEmpty(isim.Text) && !String.IsNullOrEmpty(soyisim.Text))
                {
                    try
                    {
                        DGV.DataSource = customProc.IsimVeSoyisimeGoreListe(isim.Text, soyisim.Text);

                    }
                    catch (Exception)
                    {
                        CustomMsg.Message("Veritabanı hatasi oluştu\nKonum:CustomerConnectComponent-Musterileridoldur", "Veritabanı Bağlantısı Hatası", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    }

                }
                GlobalUserComponent.DataGridViewComponent(DGV);
                return DGV;
            }
            public ComboBox cmboboxReferansDoldur(ComboBox cmbCustomerRefrence)
            {
                cmbCustomerRefrence.DataSource = new BindingSource(customProc.ReferanslarListesi(), null);
                cmbCustomerRefrence.DisplayMember = "Value";
                cmbCustomerRefrence.ValueMember = "Key";
                return cmbCustomerRefrence;
            }
            public int CustomerProccesAdd(int mID, ComboBox proccesType, NumericUpDown proccesPrice)
            {
                if (mID > 0 && !String.IsNullOrEmpty(proccesType.SelectedValue.ToString()) && !String.IsNullOrEmpty(proccesPrice.Value.ToString()) && proccesPrice.Value > 0)
                {
                    try
                    {
                        customProc.CustomerProccesAdd(mID, int.Parse(proccesType.SelectedValue.ToString()), decimal.Parse(proccesPrice.Value.ToString()));

                        CustomMsg.Message("İçerik veritabanına Eklendi", "İşlem Tamamlandı", CustomMsg.MessageIcon.OK, CustomMsg.MessageButton.OK);
                        return 1;
                    }
                    catch (Exception)
                    {
                        CustomMsg.Message("Veritabanı hatası oluştu", "Veri giriş Hatası", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                        return -1;
                    }
                }
                else
                {
                    CustomMsg.Message("Giriş değerleri hatalı", "Hata Oluştu", CustomMsg.MessageIcon.Eror, CustomMsg.MessageButton.OK);
                    return -1;
                }
            }

        }
    }


