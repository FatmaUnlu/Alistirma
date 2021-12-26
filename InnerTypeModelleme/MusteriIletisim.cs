using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriİIletisim
    {
        public int IletisimTip { get; set; }//717720001: Mobil  717770002:SabitHat
        public string Numara { get; set; }
        public string AlanKodu { get; set; }
        public bool AktifPasif { get; set; }

        public void MusteriİletisimTestMetot()
        {
            Console.WriteLine("Müsteri iletisim test metodu ");
        }


    }
}
