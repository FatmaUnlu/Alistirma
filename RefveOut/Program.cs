using System;

namespace RefveOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            degerAta(ref sayi1); //aslında değer tipli olan değişkenlerin referans tipli olmasna olanak sağlıyo.
            degerAta2(out sayi1);
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }
        static void degerAta2(out int gelenDeger)
        {
            gelenDeger = 10;
        }
    }
}
