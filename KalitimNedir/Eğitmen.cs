using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public class Eğitmen : Personel
    {
        public  Eğitmen()
        {
            Console.WriteLine("Eğitmen nesnesinin yapıcı metodu çalıştı");
        }
        public string Brans { get; set; }
        public int BransSeviye { get; set; }
        //public DateTime IsBaslangıcTarihi { get; set; }
        //public DateTime IsBitisTarihi { get; set; }
        //public int ızinGunSayisi { get; set; }

        //personel ve eğitmen clasının ortak 3 propertysi old. için ben Eğitmen nesnemi personel esnemden kalıtacagım. Bunun için eğitmen içindeki ortak propertyleri siliyorum ve eğitmen clasını basetype dan degil de personelden kalıtıyorum
    }
}
