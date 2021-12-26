using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public class BaseType
    {
        public BaseType()
        {
            Console.WriteLine("BaseType nesnesinin yapıcı metodu çalıştı");
            IdAtamaİslemi();
        }

        //her 3 class için de ortak olan alanlar
        public int Id { get; set; }
        public string ReferansKod { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime KayitTarih { get; set; }
        public int Kayitkullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int GuncellemeKullanici { get; set; }
        public bool Silindi { get; set; }

        private void IdAtamaİslemi()
        {
            Random rnd = new Random();
            this.Id = rnd.Next(1000, 9000);
        }

        public void TemelTipMetot1()
        {

            Console.WriteLine("Temel Tip=> Metot1");
        }

        

    }
}
