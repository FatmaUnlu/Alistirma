using System;
using System.Collections;

namespace HashtableÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Hashtable içine ing-türkçe data ekleyin
             *Yeni kayıt eklemek istiyor musunuz?
             *E: kayıt ekle H:Tüm listeyi yazdır
             *var olan bir key ekleniyorsa daha önceden vardı bildirimi olsun
            */
            Hashtable sözlük = new Hashtable();
            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz kelimeyi girin: ");
                Console.Write("EN: ");
                string eng = Console.ReadLine();

                if (sözlük.Contains(eng))
                {
                    Console.WriteLine($"Eklemek istediğiniz değer -{eng}- sözlükte bulunmaktadır. Türkçe karşılığı {sözlük[eng].ToString()}'dir.");
                }
                else
                {
                    Console.WriteLine($"{eng} değerinin türkçe karşılığını yazınız.");
                    string tr = Console.ReadLine();
                    sözlük.Add(eng, tr);
                    Console.WriteLine("Değer ekleme işlemi geçerli");
                }

                Console.WriteLine("Yeni kayıt eklemek istiyor musunuz? (E/H");
            } while (Console.ReadLine().ToUpper() == "E");

            //1.yöntem
            foreach (var item in sözlük.Keys)
            {
                Console.WriteLine("ENG: {0}, TR:{1}", item, sözlük[item]);
            }
            //2.yöntem
            foreach (DictionaryEntry item in sözlük)//DictionaryEntry ile datanın 
            {
                //Console.WriteLine(item.GetType().Name); //ilgili tipin adını verir
                Console.WriteLine($"ENG: {item.Key} - TR: {item.Value}");
            }
        }

    }
}
