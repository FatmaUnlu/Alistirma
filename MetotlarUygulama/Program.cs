using System;

namespace MetotlarUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            matematikselİslemler m = new matematikselİslemler();
            YenidenİslemYap:
            m.menuHazirla();
            int kullanicisecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen birinci sayı değerini girin: ");
            decimal kullaniciSayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayı değerini girin: ");
            decimal kullaniciSayi2 = int.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch (kullanicisecim)
            {
                case 1:                 
                    sonuc = m.Toplamaİslemi(kullaniciSayi1, kullaniciSayi2);
                    m.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = m.Cıkartmaİslemi(kullaniciSayi1, kullaniciSayi2);
                    m.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
               
                    break;
                    case 3:
                    sonuc = m.Bölmeİslemi(kullaniciSayi1, kullaniciSayi2);
                    m.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                case 4:
                    sonuc = m.Carpmaİslemi(kullaniciSayi1, kullaniciSayi2);
                    m.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içinde bulunamadı");
                    Console.WriteLine("Lütfen yeniden deneyiniz.");
                    Console.ReadLine();

                    goto YenidenİslemYap;
                    
            }
            Console.WriteLine("Yeni işlem yapma istiyor musunuz? (E/H)");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto YenidenİslemYap;
            }

        }
    }
}
