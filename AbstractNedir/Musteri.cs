using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
   public class Musteri : TemelSinif
    {
        public int MusteriId { get; set; }
        public Musteri() //normal sınıf örneklemesi yapılmaz ama kalıtan sınıf abstract metodu örnekleyebilir kalıtımsal açıdan
        {
            MusteriId = 1;
        }

        public override void testAbstract() 
        {
            Console.WriteLine("Müşteri sınıfın içindeki override edlmiş testAbstract metodudur.");
        }
    }
}
