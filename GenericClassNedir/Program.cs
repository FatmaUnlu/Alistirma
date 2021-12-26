using System;

namespace GenericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Id = 1;
            m1.TcKimlikNumarasi = "23456789012";
            m1.MusteriNumara = "12345";
            m1.Isim = "Fatma";
            m1.Soyisim = "Ünlü";
            m1.DogumTarih = DateTime.Parse("11.04.1996");

            MusteriGeneric<int> musteriGeneric1 = new MusteriGeneric<int>(); //T tipi diye belirtildiği için propetyde
                                                                             //burda örnekleme yapılırken tip belirtilmek zorundadır.
            musteriGeneric1.Id = 1;
            musteriGeneric1.MusteriNumaarasıAl();

            MusteriGeneric<Guid> musteriGeneric2 = new MusteriGeneric<Guid>();
            musteriGeneric2.MusteriNumaarasıAl();
        }
    }
}
