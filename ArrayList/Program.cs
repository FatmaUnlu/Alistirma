using System;
using System.Collections; // Arraylistin bullunduğu kütüphane

namespace ArrayListGenelKullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0;
            int count = 0;

            string[] isimler = new string[10];
            //araay list sınıfını kullanabilememiz için arraylist kğtğphanesi eklemeliyiz yukarıya
            ArrayList A1 = new ArrayList();
            A1.Add("Fatma Ünlü");     //Arraylisitn içine sadece bir değer eklememize yarar:Object veri itipindn değer aaldığı için istediğimiz tipte veri girebiliriz.String,int,double vs. İleride bizim oluşturacagımız tipler de olabilir.
            A1.Add(100);
            A1.Add('a');
            A1.Add(0.2d);

            //peki birden fazla değer nasıl ekleyebiliriz?AddRange komutu ile

            ArrayList A2 = new ArrayList();
            A2.Add("Fatma"); //
            A2.Add("Yüsra");

            A1.AddRange(A2); //A1 koleksiyonun içine A2 değerlerini ekledi.

            #region Capacity ve Count inceleme
            capacity = A1.Capacity;
            count = A1.Count;
            #endregion

            #region( Arraylist ) Koleksiyon içindeki elemana nasıl erişip değiştirebiliriz
            object o1 = A1[3]; // A1 içindeki 3.inedxe erişebilirz bu şekilde. Arraylistler object barındırdığı için object tipini kullandık
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            //değere ulaştık nasıl değiştirebilirim peki?
            A1[1] = "Yüsra Ünlü"; //1.elemanı yüsra ünlü ile değiştirdik.
            #endregion

            #region Arraylist sıralama
            //Dİzinin mevcut elemanlarını ters olarak sıralama
            A1.Reverse();

            //A'dan Zye sıralama
            // A1.Sort(); //burda dizi içindeki tüm değerler atnnı tip olmalı bunu kullanmak için. Örneğin hepsi string olmalı yoksa hata verir
            #endregion

            #region 10 elemanlı string arraylist içindeki değerleri zden a'ya sıralayın.
            ArrayList onluDizi = new ArrayList();
            onluDizi.Add("fatma");
            onluDizi.Add("yüsra");
            onluDizi.Add("rabia");
            onluDizi.Add("ismail");
            onluDizi.Add("ali");
            onluDizi.Add("rıza");
            onluDizi.Add("aysenur");
            onluDizi.Add("nesrin");
            onluDizi.Add("ahmet");
            onluDizi.Add("talha");

            onluDizi.Sort();
            onluDizi.Reverse();
            foreach (string item in onluDizi)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Koleksiyolar yarıdmcı komutları //if durularında yardımcı olabilir.
            bool kontrol = A1.Contains("Fatma");
            bool kontrol2 = A1.Contains(900);

            // indexOf koleksiyon içindeki değerlerin index karşılığını verir. Amaiilk buldugu index degerini bir sonraki indexlerde aynı değer varsa onu getirmz
            if (A1.Contains("Yakup"))
            {
                int indexDegeri = A1.IndexOf("Yakup");
                A1.RemoveAt(indexDegeri);
            }

            // A1.Clear() //A1 içindeki tüm elemanları siler
            // tüm elemanlar silinir ama kapasite hala varsayılana dönmez bunu sağlamak için şu komut kullanılır
            //A1.TrimToSize > ramı kullanmada etkili olur. 

            // Arraylistteki tüm elemanları diziye çevirmeye yardımcı olur

            object dizi12 = A1.ToArray(); // diziye atınca boyutu standart olarak kalır.

            #endregion

            #region (Arraylist) Koleksiyon içindeki elemanı silme
            A1.Remove(0.2d); //0.2d elemanın siler 
            A1.RemoveRange(1, 2); //1.indexten başlar 2 elaman siler
            A1.RemoveAt(3); //3.indexi siler.
            #endregion
        }
    }
}