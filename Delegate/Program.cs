using System;

namespace DelegateNedir
{
    class Program
    {
        delegate void MatematikselIslemler(int sayi1, int sayi2);
        static void Topla(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam işleminin sonucu: {0} ",Sonuc);
        }
        static void Cikart(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkartma işleminin sonucu: ", (Sonuc));
        }
        static void Carp(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işleminin sonucu: ", Sonuc);
        }
        static void Böl(int sayi1, int sayi2)
        {
            int Sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölme işleminin sonucu: ", Sonuc);
        }
        static void Main(string[] args)
        {
            //Topla(10, 20);
            //Çıkart(20, 10);
            //Çarp(20, 2);

            MatematikselIslemler M1 = new MatematikselIslemler(Topla);
            M1 += Carp; //çarp ve çıkart metotları da işaretleniyor çalışması için 
            M1 += Cikart;
          //  M1.Invoke(30, 20); //aslında ben ilgili delegemi bu girdiğim değerleri al içeride kaç tane metot işaret ediliyosa onlarda kullan şeklinde çalıştırmış oluyorum

            //hepsini sırasıyla çağırmak için
            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();

            foreach (var item in IsaretEdilenMetotlar)
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Carp; //çarp metodunu çıkart 

            foreach (var item in M1.GetInvocationList()) //bunu yapmazsak bize hep IsaretEdilenMetotlar listesini verecek baştakiyle aynı olarak
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Cikart;

            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            M1 += Carp; 

            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            Console.ReadLine();

        }
    }
}
