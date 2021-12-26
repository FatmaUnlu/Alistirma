using MetotlarGenelKullanım;
using System; //bir kütüphane dosyasını uygulamamımızın içerisine eklemektir.Eklemezsek uzun olarak komutun yolunu belirtmek zorunda kalırız

namespace MainMetodu //bunu başka bir uygulamada kütüphane olarak kullanabilriz.Namespace bir kütüphanedir
    // Hiyerarşi Kütüphane > class > metot diye ilerler.
{
    class Program
    {
        static void Main(string[] args)
        {
            //önce sınıf olmalı ki sonra metot olmalı
            // uzun şekilde yazım usingSystem kullanmayınca
            //System.Console.Write("Merhaba")
            //Selamla();

            Ogrenci o1 = new Ogrenci();

            // o1.SelamlaOgrenci();
            o1.OgrenciMetot1("Fatma", "ÜNLÜ");
        }

        static void Selamla()
        {
            Console.WriteLine("Merhaba metot");
        }
    }
}
