using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
   public class DataSource
    {
        List<Musteri> musteriler;

        public DataSource()
        {
            musteriler = new List<Musteri>();

        }

        public List<Musteri> musteriListesi()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i;
                m.Isim = FakeData.NameData.GetFirstName();
                m.Soyisim = FakeData.NameData.GetSurname();
                m.DogumTarih = FakeData.DateTimeData.GetDatetime(new DateTime(1984, 01, 01), new DateTime(1999, 01, 01));
                m.Ulke = FakeData.PlaceData.GetCountry();
                m.Il = FakeData.PlaceData.GetCountry();
                m.Ilce = FakeData.PlaceData.GetCounty();
                m.EmailAdres = $"{m.Isim.ToLower()} + {m.Soyisim.ToLower()}@{FakeData.NetworkData.GetDomain()}"; //FakeData üzerinden farklı domain adreslerine sahip mail adreslerine erişme
                m.TelefonNumarası = FakeData.PhoneNumberData.GetPhoneNumber();


                musteriler.Add(m);

            }

            return musteriler;
        }
    }
}
