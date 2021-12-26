using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericListInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4] ;

            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;


            // bu dataları List e eklemek için ilk yol ama uzun

            //for (int i = 0; i < eklenecekData1.Length; i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);
            //}

            // 2.yol AddRange : Kendi koleksyon tipine uygun dataları kendi koleksiyonuna ekler.
            sayilarim.AddRange(eklenecekData1);

            /////////////////////////////////////////////////////////////
            ///

            int capacity = sayilarim.Capacity; //kapasite hiç değer atanmadan 0, ilk değer atandığında 4, atanan değer4 ü geçtiğinde 8 olur böyle devem eder iki katı şeklinde
            int count = sayilarim.Count;

            //tüm dataları çektikten sonra count ve kapasite değerlerinin aynı olmasını sağlamak için 
            sayilarim.TrimExcess();
            capacity=sayilarim.Capacity;
            count=sayilarim.Count;

            //sayilarim koleksiyonu içindeki datayı yazdırmak istiyorum 


            sayilarim.ForEach(i => Console.WriteLine(i));
            //i nin bir anlamı yok a da olabilir b de. i koleksiyon içindeki her bir değeri ifade eder. 
            //=> bu bir lambda işareti dir. ilgili koleksiyonun içerisinde arama yap sonra ekrana yaz

            //=> linq konusudur.

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List generic koleksiyonu içerisinde 3. indekste bılunan değer {0}",bulunanDeger);

            sayilarim.Insert(3, 100); //içeriye değer ekler 3.indekse ve 3. indexte bukunan değerei bir alta kaydırır yani 4. indexe

            // sayilarim.InsertRange(); //belirtmiş olduğunuz indeksten belirtilen koleksiyon kadar aşağı doğru ekleme yapar
            bool kontrol1=sayilarim.Any(); // belirtmiş olduğumuz bir şart yoksa koleksiyon içinde bir dta var mı ona bakar varsa true gönderir.
            bool kontrol2 = sayilarim.Any(i=> i>5); //5 ten büyük değer olduğu için true döndü

            //koleksiyon içindeki elemanları sıralama
            sayilarim.Sort();// A-Z, 1-N
            sayilarim.Reverse();//Z-A

           int enYüksekDeger= sayilarim.Max();
            int enDüsükDeger = sayilarim.Min();
            int toplamDeger = sayilarim.Sum(); //içerideki değerlerin toplamı


            //dizinin içinden eleman kaldırma
            sayilarim.Remove(100); //verilen değeri koleksiyondan siler.
            sayilarim.RemoveAll(i => i > 3); //içeride belirtmiş olduğumuz değerlere karşılık gelen değerleri siler . 3ten büyükleri siler.
            sayilarim.RemoveAt(2);//belirtilen indexteki değeri siler.

            sayilarim.Clear(); //hepsini siler.


        }
    }
}
