using System;

namespace SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToString() metodu da objectten türemiştir.
            //Musteri m1= new Musteri
            //Objecttenten bir Musteri nesnem oluşur. ve bu nesnenin içinde objectten türediği için ToString () metodu da yer alır. Kalıtım yolyla gelir.
            //M1.Musteri deyince namespace ve clas adı gelir ToString in kullanımı bu şekildedir. String değer döner
            //Tostring sanal bir metottur bunu düzeltebiliriz.Mesela namespace.musteri değerini değil benim istediğim degeri ver diyebiliriz
            Musteri M1 = new Musteri();
            string mesaj = M1.ToString();
            M1.Isim = "FAtma";
            M1.Soyisim = "Ünlü";
            Console.WriteLine(mesaj);
            //SanalMetotNedir.Musteri yazacak ekrana.
            //bizim istediğimizi yazması için musteri clasında override ile ToString metodunu eziyoruz.



        }
    }
}
