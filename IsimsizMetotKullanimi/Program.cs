using System;

namespace IsimsizMetotKullanimi
{
    class Program
    {
        delegate void EkranaYaz(string Isim, string Soyisim);
        static void Main(string[] args)
        {
            //Var olan bir metodu kullanarak delegate içine ekleme
            EkranaYaz TestI = new EkranaYaz(Test1);

            //sistemde olmayan isimsiz bir metodu delegate içinde run timeda oluşturma
            EkranaYaz TestII = new EkranaYaz(delegate (string Isim, string Soyisim)
            {
                Console.WriteLine(Isim + "" + Soyisim);
            });

             //lambda exp kullanımı
             EkranaYaz TestIII = (Isim, Soyisim) =>
             {
                 Console.WriteLine(Isim + "" + Soyisim);
             };

            TestI("Fatma", "Ünlü");
            TestII("Fatma", "Ünlü");
            TestIII("Fatma", "Ünlü");
        }
        static void Test1(string Isim, string Soyisim)
        {
            Console.WriteLine(Isim + "" + Soyisim);
        }
    }
}
