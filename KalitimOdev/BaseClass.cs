using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class BaseClass //tüm nesnelerin sahip olacağı özelliklerin bulunduğu class
    {
        // nesne örneklendiğinde yalnızca bir kere çalışan yapı=static. 

        public static int sayac = 1; //ilk oluştuğunda otomatik 1 değerini alsın 

        private int _id; //id nin set edilmesini istemiyorsak
        public int Id //*
        {
            get //değeri içeriden dışarıya gönderme
            {
                return _id;
            }
            private set //dışarıdan id girişi yapılmasın.
            {
                //bir sayac içerisindeki değerden faydalanmak istiyoruz. Sayaç ile ıd kontrol edilip verilsin ürünlere. 
                //Id içeriden set edilebilir
                //_id = sayac;
                //sayac = sayac + 1;
                //ilgili işlemleri yapmış olduğumuz halde değerinin artmamasının sebebi set alanı private olarak belirtilmesi. Yani içeri değer grlmesi engellenmiş oldu. Bunu baseclassta bir constructor içerisinde yapmmamız gerek:)
            }
        }
        private string _barkod;
        public string Barkod  //* eşşsizlik kontrolü yapılacak
        {
            get //değeri içeriden dışarıya gönderme
            {
                return _barkod;
            }
             set //barkod sistemde ekliyse tekrar kaydetmesin
            {
                //bir metot oluşturmam gerek ama bunu sanaldatabase de yapmalıyımgenel kullanıma açık olmalı. Buraya da onu çağıracağım.
                bool Kontrolİslemi = SanalDatabase.DbBarkodKontrol(value);
                if (!Kontrolİslemi)//değeri sanaldb içerisinde bulamazsak
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal databas içerisinde bu barkod değeri daha önce girilmiştir");
                }

            }
        }

        public DateTime OlusturmaTarih { get; set; }
        public int OlusturanKullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int GuncelleyenKullanici { get; set; }
        public bool Silindi { get; set; }

        public BaseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }


    }
}
