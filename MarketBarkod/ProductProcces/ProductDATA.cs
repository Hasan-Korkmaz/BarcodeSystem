using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketBarkod.Model;

namespace MarketBarkod.ProductProcces
{
    class ProductDATA
    {

        Model.BarkodDataDataContext Erisim = new Model.BarkodDataDataContext();
        Products proc;
        public IQueryable UrunleriListele()
        {
            return from cat in Erisim.Categories
                   join pro in Erisim.Products
                   on cat.CategoryID equals pro.ProductCategorie
                   where pro.isActive == false
                   orderby pro.ProductName
                   select new
                   {
                       pro.ProductID,
                       pro.ProductBarcode,
                       pro.ProductName,
                       cat.CategoryName,
                       cat.CategoryID,

                       pro.ProductSalePrice,
                       pro.ProductDescription,
                   };
        }
        public IQueryable BarkodaGoreUrunListe(string Barkod)
        {
            var ara = (from cat in Erisim.Categories
                       join q in Erisim.Products
                       on cat.CategoryID equals q.ProductCategorie
                       where q.ProductBarcode.StartsWith(Barkod) && q.isActive == false
                       select new
                       {
                           q.ProductID,
                           q.ProductBarcode,
                           q.ProductName,
                           cat.CategoryName,
                           cat.CategoryID,
                           q.ProductSalePrice,
                           q.ProductDescription,
                       });
            if (ara.Equals(null))
            {
                return null;
            }
            else
            {
                return ara;
            }
        }
        public IQueryable IsmeGoreUrunListe(string ProductName)
        {

            var ara = (from cat in Erisim.Categories
                       join q in Erisim.Products
                       on cat.CategoryID equals q.ProductCategorie
                       where q.ProductName.StartsWith(ProductName) && q.isActive == false
                       select new
                       {
                           q.ProductID,
                           q.ProductBarcode,
                           q.ProductName,
                           cat.CategoryName,
                           cat.CategoryID,

                           q.ProductSalePrice,
                           q.ProductDescription,
                       });
            if (ara.Equals(null))
            {
                return null;
            }
            else
            {
                return ara;
            }
        }
        public IQueryable IsimeVeBarkoda(string barkod, string ProductName)
        {
            var ara = (from cat in Erisim.Categories
                       join q in Erisim.Products
                       on cat.CategoryID equals q.ProductCategorie
                       where q.ProductBarcode.StartsWith(barkod) && q.ProductName.StartsWith(ProductName) && q.isActive == false
                       select new
                       {
                           q.ProductID,
                           q.ProductBarcode,
                           q.ProductName,
                           cat.CategoryName,
                           cat.CategoryID,

                           q.ProductSalePrice,
                           q.ProductDescription,
                       });
            if (ara.Equals(null))
            {
                return null;
            }
            else
            {
                return ara;
            }
        }
        public Model.Products UrunAra(string barkod)
        {
            var ara = (from q in Erisim.Products
                       where q.ProductBarcode == barkod && q.isActive == false
                       select q).FirstOrDefault();

            if (ara == null)
            {
                return null;
            }
            else
            {
                return (Model.Products)ara;
            }

        }
        public int UrunEkle(string Barkod, string name, int kategoriIDs, string descriptioni, decimal satisfiyat)
        {
            //Geri Dönüş Değeri 1 ise İşlem Başarılı bir şekilde gerçekleştirimiştir
            //-1 ise Veritabanına Girişte Hata vardır
            //-2 ise Ürün Zaten Veritabanında mevcut

            //Ürün Veritabanında Var
            if (!(UrunAra(Barkod) == null))
            {
                return -2;


            }

            //Ürün Veritabanında yok ekle   
            proc = new Products()
            {
                ProductBarcode = Barkod,
                ProductName = name,
                ProductCategorie = kategoriIDs,
                ProductDescription = descriptioni,
                ProductSalePrice = satisfiyat,
                isActive = false
            };
            Erisim.Products.InsertOnSubmit(proc);
            Erisim.SubmitChanges();
            return 1;
        }
        public int UrunDuzenle(string Barkod, string name, int kategoriIDs, string descriptioni, decimal satisfiyat)
        {

            try
            {
                if (!UrunAra(Barkod).Equals(null))
                {
                    proc = UrunAra(Barkod);
                    proc.ProductName = name;
                    proc.ProductBarcode = Barkod;
                    proc.ProductCategorie = kategoriIDs;
                    proc.ProductDescription = descriptioni;
                    proc.ProductSalePrice = satisfiyat;
                    Erisim.SubmitChanges();

                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            catch (Exception)
            {
                return -1;
                throw;

            }
        }
        public int UrunSil(string Barkod)
        {
            try
            {
                proc = UrunAra(Barkod);
                proc.isActive = true;
                Erisim.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public IEnumerable<Categories> KategoriListesi()
        {
            return Erisim.Categories;
        }
    }
}
