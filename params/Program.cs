using System;

namespace paramsKullanimi
{
    class Program
{
    static void Main(string[] args)
    {
            DegerAl(10);
            DegerAl(10, 30f);
            DegerAl(10, 30f, 40.3);
            DegerAl(10, 30f, 40.3, "Yusuf");
            DegerAl(10, 30f, 40.3, "Yusuf", 3M);
            
            int sonuc = EnBuyukSayiyiBul(10, 5, 7, 99, 1531, 22, 331313);
            Console.WriteLine(sonuc);
        }

        static void DegerAl (params object [] gelenDegerler )
        {
            foreach (object item in gelenDegerler)
            {
                Console.WriteLine("Deger: {0} - Tipii {1} ", item, item.GetType().Name);
            }

            Console.WriteLine();
        }
        static int EnBuyukSayiyiBul(params int[] sayilar)
        {
            int enBuyukSayi = -1;

            if (sayilar.Length > 0)
            {
                enBuyukSayi = sayilar[0];
            }

            foreach (int sayi in sayilar)
            {
                if (enBuyukSayi < sayi)
                {
                    enBuyukSayi = sayi;
                }
            }

            return enBuyukSayi;
        }
    }
}
