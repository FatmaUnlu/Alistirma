using System;
using System.Collections;

namespace HashtableGenelKullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Hashtable h1 = new Hashtable();
            // h1.Add(key, value) Lista içinde dataya ulaşmak için kullanacağımız anahtar kelimelerdir
            //bu koleksiyonun amacı bir anahtar kalimeyi bir dataya  bağlayabilmektir
            #region yeni eğer ekleme
            h1.Add("car", "araba");
            h1.Add("house", "ev");

            //aynı keyi girmek istersek hata verir. çünkü benzersiz olmalı
            h1.Add("cars", "araba"); //burda hata vermez
            h1.Add("cars", "arabalar");// burda hata verir

            #endregion

            #region Yardımcı metotlar
            bool kontrol1 = h1.Contains("car"); //anahtar kelime aranır
            bool kontrol2 = h1.Contains("door");

            bool kontrol3 = h1.ContainsKey("house"); //keye göre arama yapar
            bool kotrol4 = h1.ContainsValue("araba"); //value ya göre arama yapar

            int koleksiyonİçindekiToplamDeger = h1.Count;
            h1.Remove("car");
            h1.Clear(); //koleksiyon içindeki her şeyi siler

           // h1["key"]=[bu anahtarın karsısına atanacak yeni değer]



            #endregion
        }
    }
}
