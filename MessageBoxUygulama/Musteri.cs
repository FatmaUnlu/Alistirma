using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxUygulama
{
    public class Musteri
    {
        public Guid Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string TelNo { get; set; }

        public override string ToString()
        {
            return Isim + Soyisim ;
        }

    }
}
