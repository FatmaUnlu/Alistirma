using System;

namespace KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //M1.Id = 1;
            //M1.İsim = "Fatma";
            //M1.Soyiİsim = "Ünlü";

            /* 1) field içerisie değer ataması yapılamasın ama değer okunabilsin
            *2)field içerisine değer ataması yapılsın ama değer okunmasın
            *3)Field içerisine atama yapılsın ama değerin ilk 4 hanesi okunsaon
            *4)field içine değer ataması ve okum işlemleri yapılsın ama bu iki işlem de bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin
            */

            // clasın içinde bir fielden değer alma ve okuma kısımlarına müdahele ettiğimiz noktalara biz encapsulatıon diyoruz.
            //Genel olarak kapsülleme konusuna giriş yaptık.

           // M1.EmailAdres = "fatmaunlu@gmail.com";
           // Console.Write(M1.EmailAdres);

            // 1) field içerisie değer ataması yapılamasın ama değer okunabilsin
            Console.WriteLine("müşteri Id " + M1.ID.ToString());

            M1.TCKimlikNo = "23454665745";
            string deger = M1.TCKimlikNo;

            //isim ve soyisim atayacağım
            //isim ve soyisim [soyisim] = set yapıcam
            //bu değerler arkada bana bi email  adresi oluşturacak
            //emali get ettiğimde fatmaunlu@gmail.com olacak
            //set: private
            M1.İsim = "Cengiz";
            M1.Soyİsim = "Attila";
            Console.WriteLine( M1.EmailAdres ); 
        }
    }
}
