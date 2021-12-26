using SiparisForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisForm.ViewModels
{
    public class SepetViewModel
    {
        public Product Urun { get; set; }
        public decimal AraToplam => Adet * Urun.UnitPrice.GetValueOrDefault();

        public int Adet { get; set; } = 0;

    }
}
