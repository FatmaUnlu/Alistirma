using System;
using System.Collections;

namespace AraayListÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList menu = new ArrayList(); // koleksiyon içindeki değerleri koruyabilmek için do while dısında tanımladık
            string kullaniciSecim = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1- Deger Ekle");
                Console.WriteLine("2- Deger Listele");
                Console.WriteLine("3- Deger Ara");
                Console.WriteLine("4- Deger Düzenle");
                Console.WriteLine("5- Deger Sil");
                Console.Write("Yapmak İstediğiniz İşlemi Seçiniz");

                kullaniciSecim = Console.ReadLine();



                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Eklemek istediğiniz değeri giriniz: ");
                        string kullaniciDeger = (Console.ReadLine());
                        menu.Add(kullaniciDeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
                        System.Threading.Thread.Sleep(2000);//2 saiye bekleyip ekranı temizleyecek.
                        break;
                    case "2":
                        //foreach (string item in menu)
                        //{
                        //    Console.WriteLine(item);
                        //}
                        //break;

                        for (int i = 0; i < menu.Count; i++)
                        {
                            Console.WriteLine("{0}. değer = {1}", i + 1, menu[i]);
                        }

                        Console.WriteLine("devam etmek için bir tuşa basınız: ");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Write("Aramak istediğiniz değeri giriniz: ");
                        string arananDeger = Console.ReadLine();
                        bool varMi = menu.Contains(arananDeger);

                        if (varMi == true)
                        {

                            int degerİndexi = menu.IndexOf(arananDeger);
                            string bulunanDeger = menu[degerİndexi].ToString();
                            Console.WriteLine($"Aranan {bulunanDeger} değeri {degerİndexi}. indekste bulunmaktadır.");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı");
                            //Console.WriteLine("Değeri listeye eklemek isterseniz E'ye basın");
                            //ConsoleKeyInfo ekle = new ConsoleKeyInfo();
                            //if (ekle.Key == ConsoleKey.E)
                            //{
                            //    menu.Add(arananDeger);
                            //}
                        }
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("Düzenlemek istediğiniz değeri girin: ");
                        string düzenlenecekDeger = Console.ReadLine();
                        Console.WriteLine("{0} değerini hangi değer ile güncellemek istersinz?: ", düzenlenecekDeger);
                        string yeniDeger = Console.ReadLine();
                        if (menu.Contains(düzenlenecekDeger))
                        {
                            int hedefİndex = menu.IndexOf(düzenlenecekDeger);
                            menu[hedefİndex] = yeniDeger;
                            Console.WriteLine("Değeriniz güncellendi");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Tüm değerleri mi silmek istyorsunuz? (E/H) ");

                        if (Console.ReadLine().ToUpper() == "E")
                        {
                            menu.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Liste içinde silmek istediğiniz değeri girin: ");
                            string silinecekDeger = Console.ReadLine();
                            if (menu.Contains(silinecekDeger))
                            {
                                menu.Remove(silinecekDeger);
                                Console.WriteLine("Değeriniz Silinde");
                            }
                            else
                                Console.WriteLine("Silmek istediğiniz değer lisitede mevcut değil");
                        }
                        Console.ReadLine();
                            break;
                    case "6":
                        break;
                    default:
                        break;

                }
            } while (kullaniciSecim != "6");
        }
    }
}
