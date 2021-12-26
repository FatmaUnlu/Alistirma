using System;

namespace MetotlarÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string ögreciAd = string.Empty;
            string ögranciSoyad = string.Empty;
            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            decimal ortalama = 0;

            Console.WriteLine("Ortalamsını hesaplamak istediğiniz öğrencini bilgilerini giriniz: ");

            Console.Write("Ad: ");
            ögreciAd = Console.ReadLine();
            Console.Write("Soyad: ");
            ögranciSoyad = Console.ReadLine();
            Console.Write("Not1: ");
            not1 = decimal.Parse(Console.ReadLine());
            Console.Write("Not2: ");
            not2 = decimal.Parse(Console.ReadLine());
            Console.Write("Not3: ");
            not3 = decimal.Parse(Console.ReadLine());

            OrtalamaAlma ort = new OrtalamaAlma();

            ort.OrtalamaAl(ögreciAd, ögranciSoyad, not1, not2, not3);
        }
    }
}
