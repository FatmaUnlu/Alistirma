using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanımı
{
    public class Urün : BaseClass
    {
        public override void ekranaYaz(string data)
        {
            base.ekranaYaz("ürün sınıfı= "+ data);
        }
    }
}
