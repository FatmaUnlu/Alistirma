using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public  class Personel : BaseType
    {
       public Personel()
        {
            Console.WriteLine("Personel nesnesinin yapıcı metodu çalıştı");
        }
        public int Seviye { get; set; }

        public DateTime IsBaslangıcTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int ızinGunSayisi { get; set; }


        

    }
}
