using System;
using System.Linq;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] ögrenciİsmiListesi = new string[5];
            //ögrenciİsmiListesi[0] = "Fatma Ünlü";
            //ögrenciİsmiListesi[1] = "Ali Kaymaz";
            //ögrenciİsmiListesi[2] = "Sevgi Alkan";
            //ögrenciİsmiListesi[3] = "Fatmagül Polat";
            //ögrenciİsmiListesi[4] = "Cemal Can";
            ////  Console.WriteLine(ögrenciİsmiListesi[0]);
            //foreach (var item in ögrenciİsmiListesi)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.Clear();

            //for (int i = 0; i < ögrenciİsmiListesi.Length; i++)
            //{
            //    string gelenİsim = ögrenciİsmiListesi[i];
            //    Console.WriteLine(gelenİsim);
            //}


            #region int veri tipinde bir dizi oluşturalım kullanıcımız dizinin kaç elemanlı olacagı bilgisini bize versin ve dizi içindeki alanlara değer ataması yapsın. Dizi içindeki elemanların toplam ve ortalamalarını yazsın

            //Console.WriteLine("Kaç elemanlı bir dizi istersiniz?: ");
            //int a = int.Parse(Console.ReadLine());
            //int[] dizi = new int[a];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine("Dizinin {0}. elemanını giriniz: ", i + 1);
            //    dizi[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Dizinin içindeki tüm elemanlar doldu. ");
            //Console.WriteLine("dizi içindeki değerlerve bu değerlerin ortalama ve toplam değerleri aşağıdadır: ");

            //int toplam = 0; int ortalama = 0;
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine("Dizinin {0}. değeri: " + item);
            //    toplam = toplam + item;
            //    ortalama = toplam / a;

            //}
            //Console.WriteLine("toplam :" + toplam);
            //Console.WriteLine("ortalama:" + ortalama);
            #endregion

            #region GetLenght: dizinin eleman sayısını bulmak için


            //int[] diziElemanSsyısı = { 1, 4, 7, 9 };
            //Console.Write(diziElemanSsyısı.GetLength(0));

            #endregion
            #region CopyTo : Dizi kopyalamak için
            //int[] dizi1 = { 1, 2, 3, 4 };
            //int[] dizi2 = new int[10];
            //dizi1.CopyTo(dizi2, 3);

            ////Burada dizi1’in 3.Elemanından itibaren dizi2’ye kopyalama işlemi gerçekleşir.
            ////İstenirse dizi sınıf(Array) kullanılarak bir dizinin sadece belirli bir bölümü kopyalanabilir.


            //int[] dizi3 = { 1, 2, 3, 4 };
            //int[] dizi4 = new int[10];
            //Array.Copy(dizi3, dizi4, 3);

            //  Bu örnekte dizi1’in 3.Elemanından itibaren dizi2’ye kopyalama işlemi gerçekleşir.

            //int[] dizi5 = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] dizi6 = new int[10];
            //Array.Copy(dizi5, 2, dizi6, 7, 3);

            // Burada dizi5’in 2.indeksinden itibaren 3 eleman, dizi6’ya 7.indeksten itibaren kopyalanıyor.

            #endregion
            #region IndexOf(); dizi içinde harf ya da kelime aramamıza yarar.
            //Array.IndexOf();
            //Dizi içinde harf ya da kelime aramamıza yarar. Eğer harf ya da kelimeyi bulursa bulduğu ilk indexi gönderir.Bulamazsa geriye -1 gönderir.

            //Array.IndexOf(dizi1, 2);
            //2 ifadesini dizi1 dizisinde arar. Bulduğu ilk indexi gönderir.

            //Array.IndexOf(sayilar, 2, 3);
            //Bu methot ise 3.elemandan itibaren arama yapar.

            #endregion

            #region Array.Reverse(): Dİzi elemanlarını ters çevirir.

            //Dizinin elemanlarını ters çevirir. Ancak sadecetek boyutlu diziler için kullanılabilir.
            // Array.Reverse(dizi);

            #endregion
            #region Array.Sort(): Elemanları sıralama küçükten büyüğe
            // Dizinin elemanlarını küçükten büyüğe doğru olacak şekilde sıralar.
            // Array.Sort(dizi);
            #endregion

            #region Array.Clear();
            //Bu kod dizi dizisinin 1.indeksinden itibaren 3 indeksini sıfırlar(varsayılan değere döndürür).
            //Array.Clear(dizi, 1, 3);
            #endregion


            #region 20 elemanlı bir int dizi oluşturalım. Değerleri random 1-10 arası değerler ile doldoralım Dizi içindeki elemanlarımızı ekrana yazdıralım. İlgili dizi içinde kaç tane 4 değeri var onu bulalım.

            //int[] diziElemanArama = new int[20];
            //Random randomDeger = new Random();
            //int sayac = 0;

            //for (int i = 0; i < diziElemanArama.Length; i++)
            //{
            //    int rnd = randomDeger.Next(1, 10);
            //    diziElemanArama[i] = rnd;
            //}
            //foreach (int item in diziElemanArama)
            //{

            //    Console.Write(item);
            //    if (item == 4)
            //        sayac++;

            //}

            //Console.WriteLine($"Dizi içerisinde {sayac} tane 4 bulunmaktadır, ");

            #endregion

            #region Verilen bir string dizisini, ters sırada (sondan başa doğru) listeleyen C# programını yazınız.
            //string[] TerstenSıralama = new string [] { "Fatma", "Talha", "Ahmet", "İsmail", "Yüsra" };
            //Array.Reverse(TerstenSıralama);
            //foreach (string item in TerstenSıralama)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("----------------------------------");


            //for (int i =TerstenSıralama.Length - 1; i>=0 ; --i)
            //{
            //    Console.Write(TerstenSıralama[i]);
            //}

            #endregion

            #region Tanımlanan sayılar dizisi içerisindeki çift sayıları ekrana yazdıran C# konsol uygulamasını yazınız
            //int[] sayilar = new int[] { 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine("Dizi içerisindeki çift sayılar: ");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            //Console.WriteLine($"Dizi içerisindeki çift sayılar: ");
            //foreach (int item in sayilar)
            //{
            //    if (item % 2 == 0)
            //        Console.WriteLine(item);
            //}

            #endregion

            #region Kullanıcıdan alınan metin içindeki sesli harf sayısını bulan C# console uygulamasını yazınız.

            //Console.WriteLine("Bir metin giriniz: ");
            //string metin = Console.ReadLine();
            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            //int sayac = 0;

            //for (int i = 0; i < sesliHarfler.Length; i++)
            //{
            //    for (int j = 0; j < metin.Length; j++)
            //    {
            //        if (sesliHarfler[i] == metin[j])
            //            sayac++;
            //    }
            //}
            //Console.WriteLine($"{sayac} tane sesli harf vardır.");

            #endregion

            #region Sayısal loto uygulamasını C# programı kullanarak yapınız. Bu uygulama da 1 ile 49 arasındaki sayılardan rastgele olacak şekilde 7 adet sayı üretilsin ancak bu sayıların hiçbiri birbiri ile aynı olmasın. Bu senaryoyu gerçekleştirecek C#programını yazınız.
           // Random rnd = new Random();
           // string[] lotoSayisi = new string[7];
           //string sayi = string.Empty;
           // for (int i = 0; i < 7; i++)
           // {
           //      sayi = (rnd.Next(1, 49)).ToString() ;

           //     if (!lotoSayisi.Contains(sayi))

           //          lotoSayisi[i] = sayi;

           //     Console.WriteLine(lotoSayisi[i]);
           // }
            
            #endregion

        }
    }
}
