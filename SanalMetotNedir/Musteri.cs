using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotNedir
{
   public class Musteri //normal şartlarda :kalıtılacak nesne yazıyoduk.Fakat object kkalıtımı için biz bunu yazmıyroruz otomatik olarak objectten bir kalıtım geliyo zaten.
    {
        public int  MusteriId { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public override string ToString()
        {
            //return base.ToString(); //base kalıtılan clası gösterir. Burada object clasını işaret ediyor.
            return Isim + " " + Soyisim; //tostring metodunu override ettik artık tostring kullanıldığında return olarak isim ve soyisim görünecek
        }

    }
}
