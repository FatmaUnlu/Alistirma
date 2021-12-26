using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeNedir
{
    internal class Musteri //namespaca içinde yani geçerli proje içinde erişilebilir olsun. onun dışında private gibi davransın. Örneğin bir dll hazırlaldım ve kütüphaneyi başka bir uygulamayla paylasıyorum ve o uygulamanın benim clasımı görmesini istemiiyorum. O zaman internal kullanmalıyım.
    {
        //  1) field içerisie değer ataması yapılamasın ama değer okunabilsin
        public Musteri() //constructor. Bir nesne oluştuğu zaman bir meot yardımıyla bir değer üret ve ürettiğin değeri içeride private olarak duran fieldın içerisine ata diyoruz.
        {
            this.id = IDUret(); //property dışaarıdan değerlere ulaşmak için kullaılır benzaten clasın içindeyim o yüzden fieldı almalıyım.
        }
        //clasın fieldları
        private int id; //başına private yazmasam da default değeri privatettır.
        public int ID
        {
            get //içerideki private değeri alıp onu çağıran koda iletiyorum property yardımı ile
            {
                return this.id;
            }
            private set //private dışarıdan değer ataması yapılmasını önler.
            {
                this.id = value;
            }
        }

        public string İsim;

        private string _soyIsim;
        public string Soyİsim
        {
            get
            {
                return this._soyIsim;
            }
            set
            {
                this._soyIsim = value;
                this.emailAdres = string.Format("{0}.{1} @ gmail.com",İsim,Soyİsim);
            }
        }

        private string _tckimlikNo;
        public string TCKimlikNo
        {
             get
            {

                string sonuc = this._tckimlikNo.Substring(0, 3);
                return sonuc;


            }
            set
            {
                //if (value.Length != 11)
                //{
                //    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır");

                //}

                //foreach (char item in value)
                //{

                //    if (char.IsDigit(item) || char.IsSymbol(item) || char.IsControl(item) || char.IsPunctuation(item))
                //    {

                //    }
                //}
                //if (value.StartsWith("0"))
                //    throw new Exception("kimlik numarası sıfır ile başlayamaz");

                //if (!(int.Parse(value.Substring(9)) % 2 == 0))
                //    throw new Exception(" kimlik numarasının son hanesi çift rakam olmalıdır");

                //2.yol

                bool bayrak = false;
                for (int i = 0; i < value.Length; i++)
                {
                    bool karakterKontrol = char.IsNumber(value[i]);
                    if (karakterKontrol)
                    {
                        //sayısal değer demektir
                    }
                    else
                    {
                        bayrak = true;
                        break;
                    }
                }
                if (bayrak)
                {
                    Console.WriteLine("Tckimlik no içindeki değerler sayısal olmalıddır.");
                }
                else
                {
                    this._tckimlikNo = value;
                }
            }



        }

        // public string EmailAdres;

        private string emailAdres;  //field

        //class içerisindeki propertyler

        public string EmailAdres
        {
            get //db veya farklı bir veri kaynağından datayı çektiğimizde değeri karşıya gösterir. Clası çağıran programcıya datayı gösterdiğimiz kısım.
            {
                return this.emailAdres;
            }
            private set //dış dünyadan alınan datanın içeride private olarak saklanan field içerisinedeğer atandığı kısım
            {
                this.emailAdres = value;
            }
        }


        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);
        }

    }
}
