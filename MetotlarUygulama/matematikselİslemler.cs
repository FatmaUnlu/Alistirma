using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarUygulama
{
    public class matematikselİslemler
    {
        //Topla
        public decimal Toplamaİslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        //çıkar
        public decimal Cıkartmaİslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //bölme
        public decimal Bölmeİslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        //çarpma
        public decimal Carpmaİslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        //ekrana yazdırma metotu
        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("***** Menü *****");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkartma");
            Console.WriteLine("3 - Bölme");
            Console.WriteLine("4- Çarpma");
            Console.Write("Lütfen değer seçiniz: ");
        }

        //ekrana sonuc yazdırma
        public void sonucEkranaYaz (decimal kullaniciSayi1,decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine( $" İşleminizin sonucu {kullaniciSayi1} {operators} {kullaniciSayi2} = {sonuc}");
        }
    }
}
