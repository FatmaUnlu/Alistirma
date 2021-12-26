using System;

namespace InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.MüsteriId = 1;
            M1.TcKİmlikNo = "23456729849";
            M1.Isim = "Fatma";
            M1.Soyisim = "Ünlü";
            M1.OlusturmaTarihi = DateTime.Now;


            //M1.müsteriAdresleri = new MusteriAdres[5];
            //yukarıdaki satırın yeri burası değil.Burdada çalışır ama buraya koymayın. Bu tip inner typeları bu tip koleksiyonları örneklediği yerler ilgili anatipin yapacı metodudur. Müsteri clası mesela bunun yeri

            M1.musteriAdresleri[0] = new MusteriAdres() //innertype
            {
                Il = "İstanbul",
                Ilce = "K.Cekmece",
                Adres = "sldjfkldgkldf",
                adresTip = "İs yeri"

            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                SiparisNo = "SIP0001"
            };

            M1.musteriSiparisBilgileri[0].Urunler[0] = new Urun()
            {
                UrunId = 1,
                Tanim = "Çikolata",
                Fiyat = 2,
            };
          
        }
    }
}
