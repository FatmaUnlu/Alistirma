using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class Musteri
    {

        #region Tekil Olarak kullanılan propertyler- Müşteriye özel alanlar yani

        public int MüsteriId { get; set; }
        public string TcKİmlikNo { get; set; }

        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public DateTime OlusturmaTarihi { get; set; }
        public int KullaniciId { get; set; }

        #endregion

        #region innertype gerektiren fieldlar
        //public string adresTip { get; set; } //bu şekilde yaparsak müşterinin 5 adresi oldğunu varsayalım. AdresTip1, AdresTip2 vs gibiiçeride kendini tekarar eden field bloklar oluşturmak zorundayız. Bunun yerine aslında modellemek istediğimiz konu şu : MüşteriAdres adında bir tip oluşturmak burada oluşturduğumuz adres tip il ilçe adres bilgisini MüşteriAdres nesnesi içerisine aktarmak ve müşteri nesnesinin içinde bir koleksiyon olarak adresimizi tanımlamak
        //public string Il { get; set; }
        //public string Ilce { get; set; }
        //public string Adres { get; set; }
        //bu fieldları Müşteri adres içine taşıyorum

        #endregion

        #region inner type gerektiren propertyler
        public MusteriAdres[] musteriAdresleri; //burada müşteri nesnemizin içinde müşteriadres nesnemizi bir koleksiyon olarak tanımlamış olduk. Birden fazla adresi bulundurabilecek içinde bu sayede
        public MusteriİIletisim[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;
        #endregion

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriİIletisim[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }


    }
}
