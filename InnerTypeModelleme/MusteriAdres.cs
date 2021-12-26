using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriAdres
    {
        public string adresTip { get; set; } //bu şekilde yaparsak müşterinin 5 adresi oldğunu varsayalım. AdresTip1, AdresTip2 vs gibiiçeride kendini tekarar eden field bloklar oluşturmak zorundayız. Bunun yerine aslında modellemek istediğimiz konu şu : MüşteriAdres adında bir tip oluşturmak burada oluşturduğumuz adres tip il ilçe adres bilgisini MüşteriAdres nesnesi içerisine aktarmak ve müşteri nesnesinin içinde bir koleksiyon olarak adresimizi tanımlamak
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Müsteri adres yapıcı metodu çalıştı");
        }
        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("Müsteri adres test metodu ");
        }
    }
}
