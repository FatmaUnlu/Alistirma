using System;

namespace WhileDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while döngüsü genel kullanımı
            ////ekrana 1den 10 a kadar sayıların değerlerini yazdıralım
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion

            #region kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım

            //Console.WriteLine("Sayi giriniz ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //while(sayi!=-1)
            //{
            //    Console.WriteLine(sayi);
            //    sayi--;
            //}
            #endregion

            #region kullanıcıdan gelen  değerlerin toplamını ekrana yazalım. =dan küçük bir değer girişi yapılırsa toplama işlemini bitirelim. ve ekrana toplam sonucu yazalım

            //Console.WriteLine("Toplamak istediğiniz sayilari giriniz ");
            //Console.WriteLine("Not: -1 değeri işlemlerinizi durdurur. ");


            //int toplam = 0;

            //while (true)
            //{
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    if (sayi2 < 0)
            //        break;
            //    else
            //        toplam =toplam+ sayi2;

            //}
            //Console.WriteLine("Girdiğiniz sayıların toplamı: {0}" , toplam);
            #endregion
            #region Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini sağlayacak biir uygulama
            int sistemÜretSayi = 0;
            int tahmin = 1;
            Random random = new Random();
            sistemÜretSayi = random.Next(1,10);

            while (true)
            {
                Console.Write("{0}. deneme , sistemin üretmiş oldğu sayıyı tahmin ediniz: ", tahmin);
                string kullanicidanGelen = Console.ReadLine();

                if (int.Parse(kullanicidanGelen)==sistemÜretSayi)
                {
                    
                    Console.WriteLine("Tebrikler, {0}. denemenizde değeri buldunuz " , tahmin);
                    break;
                    tahmin++;
                }
                else
                {
                    Console.WriteLine( "{0}. denemenizde tahmin edemediniz. Lütfen tekrar deneyiniz. ",tahmin);
                    tahmin++;
                }
                Console.Clear();
            }
            
            


            #endregion
        }
    }
}
