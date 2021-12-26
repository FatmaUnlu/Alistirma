using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
   public class Ogrenci : BaseType
    {
        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesinin yapıcı metodu çalıştı");
        }
        public string Bolum { get; set; }
        public int Seviye { get; set; }


    }
}
