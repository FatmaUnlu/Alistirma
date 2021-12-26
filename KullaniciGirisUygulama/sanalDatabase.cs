using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisUygulama
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                Id = 1,
                Isim = "fatma",
                Soyisim = "ünlü",
                KullaniciAdi = "fatma.unlu",
                Sifre="1",
                Aciklama="fatma ünlü kullanıcı profil bilgisi"

            });

            KullaniciTablo.Add(new kullanici()
            {
                Id = 2,
                Isim = "ali",
                Soyisim = "ünlü",
                KullaniciAdi = "ali.unlu",
                Sifre = "2",
                Aciklama = "ali ünlü kullanıcı profil bilgisi"

            });

            KullaniciTablo.Add(new kullanici()
            {
                Id = 3,
                Isim = "yüsra",
                Soyisim = "ünlü",
                KullaniciAdi = "yüsra.unlu",
                Sifre = "3",
                Aciklama = "yüsra ünlü kullanıcı profil bilgisi"

            });

        }

    }
}
