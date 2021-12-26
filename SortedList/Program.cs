using System;
using System.Collections;

namespace SortedListGenelKullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hastable gibi key ve value değerlerinden oluşur. Fakat farklı olarak içerisine aldığı değerleri key değerine göre küçükten büyüğe doğru sıralar.
            //Sralama olduğu için key değerlerini eşsiz olmasının yanında aynı tipte de olması gerekir.
            SortedList SortedLSt = new SortedList();
            SortedLSt.Add(100, "Yüz");
            SortedLSt.Add(90, "Doksan");
            SortedLSt.Add(1, "Bir");
            SortedLSt.Add(7000, "Yedibin");

            //SortedLSt.Add("a", "b"); // hata verir yukarıdakilerle aynı tipte olmadığı için
            //Hashtable ile aynı metotlara bağlıdır.
        }
    }
}
