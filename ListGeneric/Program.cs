using System;
using System.Collections;
using System.Collections.Generic;

namespace ListGeneric //arraylistin generic versiyonu.
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            // <T> : Ttipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demektir.

            List<int> ListGeneric = new List<int>();
            ListGeneric.Add(1);
            ListGeneric.Add(2);
            //  ListGeneric.Add("Ali"); hata verir

            for (int i = 0; i < ListGeneric.Count; i++)
            {
                Console.WriteLine(ListGeneric[i]);
            }

            List<string> isimler = new List<string>();

            isimler.Add("Fatma;");
            isimler.Add("Yüsra");
            isimler.Add("Rabiye");
            isimler.Add("İsmail");

            //Liste içindeki elemanları ekrana yazdırma
            foreach (string item in isimler)
            {
                Console.WriteLine(item);
            }

            List<Musteri> musteriListe = new List<Musteri>();
            musteriListe.Add(new Musteri() //custom veritipini listeye ekleme
            {
                ID=1,
                Ad="Fatma",
                Soyad="Ünlü"
            });
            foreach (Musteri item in musteriListe)
            {
                Console.WriteLine(item.Ad);
            }
        }
    }
}
