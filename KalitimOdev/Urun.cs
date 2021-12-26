using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class Urun : BaseClass
    {
        private decimal _alisfiyati;
        public decimal AlisFiyati //alış fiyatı 0 dan küçğk olmamalı
        {
            get
            {
                return _alisfiyati;
            }
            set
            {
                if (value <= 0) //gelen değeri value ile yakalıyorum
                {
                    Console.WriteLine("Alış fiyatı sıfırdan küçük veya büyük  olamaz");
                }
                else
                {
                    _alisfiyati = value;
                }

            }
        }

        private decimal _satisFiyati;
        public decimal SatisFiyatı //satış fiyatı alış fiyatından küçük olamaz
        {
            get
            {
                return _satisFiyati;
            }
            set
            {
                if (value < _alisfiyati)
                {
                    Console.WriteLine("satış fiyatı alış fiyatından küçük olamaz");
                }
                else
                {
                    _satisFiyati = value;
                }
            }
        }
        private decimal _kampanyaFiyat;
        public decimal KampanyaFiyat //kampanya fiyatı sıfırdan küçük olmamalı 
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("kampanya fiyatı sıfırdan küçük olmamalı ");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }

        }
        public string Marka { get; set; }//belirtilen markalar içerisinde ürün eklenebilsin. 


        public string Model { get; set; }

    }
}
