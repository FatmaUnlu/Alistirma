using System;

namespace AşırıYüklenme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //bu da overload bir metottur.

            Topla(3, 5);
        }

        static void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void Topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void Topla(string metin1, string metin2)
        {

            Console.WriteLine(metin1 + " " + metin2);
        }
    }
}
