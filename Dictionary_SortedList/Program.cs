using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu koleksiyonların işlevi Haashtable koleksiyonuyla aynıdır. Key değeri unique
            //olmalı value değeri ise kendini tekrar eden bir data da olabilir.

            //Generic olmayan koleksiyon davranışı
            Hashtable HtList = new Hashtable();
            HtList.Add(1, "Bir");
            HtList.Add(2, "iki");
            HtList.Add(3, "Üç");
            //HtList.Add(1, "Test"); 


            //Dictionary <TKey, TValue> 
            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "İki");
            DictionaryList.Add(3, "Üç");
            // DictionaryList.Add(1, "Test");

            bool silmeSonuc = DictionaryList.Remove(2); //değeri list te bulduysa silip true değeri döner. Bulamadıysa false
            if (silmeSonuc == true)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Silme işlemi basarısız");
            }

            //burda 1. keyi silip arama yapsa değerini hata verir. Bu hataları almak istemiyorsam kontrollerden faydalanabilirim.

            bool arananDegerSonuc = DictionaryList.ContainsKey(1);

            if (arananDegerSonuc)
            {
                string gelenDeger = DictionaryList[1]; // list içerisinde 1 anahtarına karşılık gelen değeri getirir
                gelenDeger = "Yenilenen Değer";
                DictionaryList[1] = gelenDeger; 
            }
            else
            {
                Console.WriteLine("Aranan değer koleksiyon içinde bulunamadı");
            }

            //aynı işlem value ler için de yapılabilir.

           Boolean arananDeger = DictionaryList.ContainsValue("Üç");
            if (arananDeger)
            {
                Console.WriteLine("Aranan değer bulundu");
            }
            else
            {
                Console.WriteLine("Aranan değer koleksiyon içinde bulunamadı");
            }

            //dictionary listte ki key value elemanlarını dönmek için 

            foreach (KeyValuePair<int, string> item in DictionaryList)
            {
                Console.WriteLine("Anahtar: {0} || Değer: {1}", item.Key, item.Value); ; 
            }

            DictionaryList.Clear();

            //SortedList Koleksiyonu
            //dictionary koleksiyonunun yaptığı işlemlerin hepsini yapabilir. Kendisine atanan key göre bir sıralama yapar.
            //int ise kçükten büyüğe doğru, string ise küçk harften büyük harfe

            SortedList<int, string> sortedListKoleksiyon = new SortedList<int, string>();

            sortedListKoleksiyon.Add(100, "Yüz");
            sortedListKoleksiyon.Add(50, "Elli");
            sortedListKoleksiyon.Add(1, "Bir");
            sortedListKoleksiyon.Add(1000, "Bin");



        }

    }
}
