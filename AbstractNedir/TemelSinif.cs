using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
    public abstract class TemelSinif //bu sınıftan kalıtılanlar bu sınıftaki kurallara uyacak ve bu sınıftan nesne üretilemez
    {
        public DateTime KayitTarih { get; set; }
        public DateTime GüncellemeTarih { get; set; }

        public TemelSinif()
        {
            KayitTarih = DateTime.Now;
            GüncellemeTarih = DateTime.Now;
        }
        public void Test()
        {
            Console.WriteLine("Temel Sınıf => test");
        }

        public abstract void testAbstract(); //abstract metotların body kısmı olmaz. Bu sınıfı kalıtan nesne benim içeride hazırlamış olduğum mesajları fieldları propertyleri kullanmak zorunda kalacak. Sadece metot imzası olan kısım yazılıp bırakılır.
       
    }
}
