using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxUygulama
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunResim { get; set; }
        public string UrunKategori { get; set; }
        public int StokAdet { get; set; }
        public string Yazar { get; set; }
        public string Aciklama { get; set; }
        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
