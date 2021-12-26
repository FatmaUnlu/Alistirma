using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarÖdev
{
    public class OrtalamaAlma
    {
        public void OrtalamaAl(string ÖgrenciAd, string ögrenciSoyad, decimal not1, decimal not2, decimal not3 =45) // =45 burada not3 ün değeri girilmeyebilir ,girilmezse default değer 45 olur demektir.En sonda tanımlamam gerekir. Yoksa ondan sonraki hepsi opsiyonel parametre olarak alınır.
        {
            Console.WriteLine($"öğrencinin Bilgileri: {ÖgrenciAd} {ögrenciSoyad} => {not1} , {not2}, {not3}  ");
            decimal ortalama = OrtalamaHesapla(not1, not2, not3);
            ortalamaNotDegerlendir(ortalama);

            Console.WriteLine($"İlgili öğrencinin ortalaması: {ortalama}");

            ortalamaNotDegerlendir(OrtalamaHesapla(not1, not2, not3));//iç içe geçmiş şekilde kullanabiliriz metotları üsteeki işlemle aynı sonuç verir bu.

        }

        void ortalamaNotDegerlendir (decimal ogrenciOrtalama)
        {
            if (ogrenciOrtalama < 45)
            {
                Console.WriteLine("Kaldı");
            }
            else
            {
                Console.WriteLine("Geçti");
            }
        }
        private decimal OrtalamaHesapla(decimal ögrenciNot1, decimal ögrencinot2, decimal ögrenciNot3)
        {
            decimal ortalama = (ögrenciNot1 + ögrencinot2 + ögrenciNot3);
            return ortalama;
        }
        

    }
}
