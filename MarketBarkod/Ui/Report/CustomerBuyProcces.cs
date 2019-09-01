using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.IO;
using MarketBarkod.GlobalComponent.CustomFont;

namespace MarketBarkod.Ui.Report
{
    public partial class CustomerBuyProcces : UserControl
    {
        int musteriID;
        MarketBarkod.CustomerProcces.CustomerDATA CD = new MarketBarkod.CustomerProcces.CustomerDATA();
        Model.Customers cust = new Model.Customers();
        public CustomerBuyProcces(int musteriID)
        {

            this.musteriID = musteriID;
            InitializeComponent();
            cust = CD.MusteriIDyeGöreAra(musteriID);
            label3.Text = cust.CustomerName + cust.CustomerSurname + " müşterisinin hangi tarihler arasındaki satın\n alımlarını görmek istiyorsunuz ?";
            dateTimePicker1.Value = DateTime.Now.AddDays(-30);
        }

        private void CustomerReport_Click(object sender, EventArgs e)
        {
            
            byte fileState = 0;
            try
            {
                //Dosya Açıksa Kod Burada Patlar ve catche atar
                using (Stream stream = new FileStream(Application.StartupPath + "..\\..\\..\\KaydedilenRaporlar\\CustomerTasks.pdf", FileMode.Open,FileAccess.Write))
                {
                    fileState = 1;
                }
            }
            catch (Exception)
            {
                CustomMessage.CustomMsg.Message("Dosya açık olduğu için işlem gerçekleştirilemiyor...\nBütün pdf dosyalarını kapatın ve yeniden rapor almayı deneyin", "System.IO.Exeption", CustomMessage.CustomMsg.MessageIcon.Eror, CustomMessage.CustomMsg.MessageButton.OK);
                fileState = 0;
            }
            if (fileState == 1)
            {
                FileStream file = new FileStream(Application.StartupPath + "..\\..\\..\\KaydedilenRaporlar\\CustomerTasks.pdf", FileMode.Open, FileAccess.Write);
                Document document = new Document();
                MarketBarkod.CustomerProcces.CustomerDATA CD = new MarketBarkod.CustomerProcces.CustomerDATA();
                PdfWriter writer = PdfWriter.GetInstance(document, file);
                TitiliumFastFont tit = TitiliumFastFont.getInstance;
                decimal? totalDiscount = 0;
                decimal? totalToplam = 0;



                tit.FontSize = 14;
                tit.Color = System.Drawing.Color.Black;
                if (document.IsOpen() == false)
                {
                    document.Open();
                }
                PdfPTable productTable = new PdfPTable(3) { WidthPercentage = 100 };
                productTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell cell = new PdfPCell(new Phrase(cust.CustomerName+" "+cust.CustomerSurname+" Satın Alma Dökümü", tit.TitiliumWebSemiBold));
                cell.Colspan = 4;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right

                productTable.AddCell(cell);
                productTable.AddCell(new Paragraph("Ürün Adı", tit.TitiliumWebRegular));
                productTable.AddCell(new Paragraph("Ürün İndirimi", tit.TitiliumWebRegular));
                productTable.AddCell(new Paragraph("ÜrünFiyatı", tit.TitiliumWebRegular));

                foreach (var item in CD.musteriProductDokum(musteriID, dateTimePicker1.Value, dateTimePicker2.Value))
                {
                    totalDiscount += item.ProductDiscount;
                    totalToplam += item.ProductPrice;
                    productTable.AddCell(new Paragraph(item.Products.ProductName, tit.TitiliumWebRegular));
                    productTable.AddCell(new Paragraph(item.ProductDiscount + " TL", tit.TitiliumWebRegular));
                    productTable.AddCell(new Paragraph(item.ProductPrice + " TL", tit.TitiliumWebRegular));
                }

                PdfPTable totalTable = new PdfPTable(2) { WidthPercentage = 100 };
                totalTable.AddCell(new Paragraph("Toplam İndirim : " + totalDiscount + " TL", tit.TitiliumWebRegular));
                totalTable.AddCell(new Paragraph("Ürün Bedel Toplam : " + totalToplam + " TL", tit.TitiliumWebRegular));

                PdfPCell geneltoplam = new PdfPCell(new Phrase("Genel Toplam : " + (totalToplam - totalDiscount) + " TL", tit.TitiliumWebSemiBold));
                geneltoplam.Border = iTextSharp.text.Rectangle.NO_BORDER;
                geneltoplam.HorizontalAlignment = 1;
                geneltoplam.Colspan = 2;
                totalTable.AddCell(geneltoplam);




                document.Add(productTable);
                document.Add(totalTable);
                document.AddAuthor("RitimSoft->MrKaraca");
                document.AddCreator("RitimSoft->Barkod");
                document.AddTitle("Müsteri Satın Alma Dökümü");
                document.AddSubject("24 Saat içinde yapılan satımlar");
                document.AddKeywords("24 Saat içinde yapılan satışlar ve bu satışların toplamı");
                document.Close();
                file.Close();
                Process.Start(Application.StartupPath + "..\\..\\..\\KaydedilenRaporlar\\CustomerTasks.pdf", "chrome");
            }
        }
    }
}
