using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Tanim { get; set; }
        public decimal Fiyat { get; set; }

        public Urun()
        {
        Console.WriteLine("Ürünün yapıcı metodu çalıştı.");
        }
        public void TestMethod()
        {
            Console.WriteLine("UrunTest Method ");
        }
    }
}
