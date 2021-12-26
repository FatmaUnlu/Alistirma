using System;

namespace EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.Id = 1;
            M1.MusteriNumara = "63463";
            M1.Isim = "Cengiz";
            M1.Soyisim = "Atilla";
            M1.EmailAdres = "flsdşfklsdjfklsg";

            SanalDatabase sDB = new SanalDatabase();
            sDB.MusteriYeniKayit(M1); //arrayliste musteriyenikayıt metodunu kullanarak erişebiliyorum.
            //
            //int musteriKayitSonuc = sDB.MusteriYeniKayit(M1); artık tipim int değil enum kullandıktan sonra. Enum yapısının adı olan MusteriReturnValue

            MusteriReturnValue musteriKayitSonuc = sDB.MusteriYeniKayit(M1);
            int enumInt = (int)MusteriReturnValue.kayitBasarisiz;
            Console.WriteLine(enumInt); //kayıtbaşarısız değeri enumda 1 numara old. için 1 yazılır ekrana
            
            
            
            
            //if (musteriKayitSonuc== MusteriReturnValue.kayıtBasarili) 
            //{

            //}
        }

    }
}
