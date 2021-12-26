using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriSiparisBilgisi
    {
        public string SiparisNo { get; set; }

        public Urun[] Urunler; //innertype gerektiren field

        public MusteriSiparisBilgisi()
        {
            Urunler = new Urun[10];
        }
        public void MusteriSiparisBilgisiTestMetot()
        {
            Console.WriteLine("Müsteri siparis bilgisi test metodu ");
        }



    }


}
