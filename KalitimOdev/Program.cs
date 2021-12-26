using System;

namespace KalitimOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
          // B1.Id = 1; //bu değeri girmek istemiyorum otomatik gelmesini istiyorum. Aynı zamanda set edilebilir bir durum da bırakılmasın istiyorum. Yani B1.Id dediğimde hata versin ama kendisi ıd değerlerini eşsiz bir şekilde dağıtsın. Baase classta yaptığım işlemlere bak. Id properrtysi için
            B1.Marka = "Lenovo";
            B1.Model = "z50";
            B1.Islemci = "i5";
            B1.AlisFiyati = 1500M;
            B1.SatisFiyatı = 1600M;
            B1.KampanyaFiyat = 1000M;
            B1.Barkod = "234345346";

            //bir db oluşturup bunun içine verileri(ürün) atmak istiyorum. Sora barkodlarla o ürünün kontrolünü yapabiliriz. Bu listenin Tekil olsun. Nesne örneklendiğinde o da bir kere örneklensin  ve ürün eklendikçe  içinde saklansın. Sanal bir db yapalım 

            SanalDatabase.YeniUrünEkle(B1);

            Bilgisayar B2 = new Bilgisayar();

            B2.Marka = "Lenovo";
            B2.Model = "z50";
            B2.Islemci = "i5";
            B2.AlisFiyati = 1500M;
            B2.SatisFiyatı = 1600M;
            B2.KampanyaFiyat = 1000M;
            B2.Barkod = "234345346";

            SanalDatabase.YeniUrünEkle(B1);

        }
    }
}
