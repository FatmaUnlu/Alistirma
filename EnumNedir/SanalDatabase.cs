using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    public class SanalDatabase
    {
        ArrayList sanalDb = new ArrayList(); //sanalDb yi bu şekilde tanımlayınca erişim belirteci private oluyor. SanaldbYe metotlarla erişebiliyor olacağım

        //public int MusteriYeniKayit(Musteri M)
        public MusteriReturnValue MusteriYeniKayit(Musteri M)// Musterireturn value yu enum yapmıştık
        {
            //parametre kontrol yapılabilir 
            //kayıt kontrol yapılabilir 

            sanalDb.Add(M);
            return MusteriReturnValue.kayıtBasarili; //714329579; //bu değerler bir süre sonra nerden nasıl geldiği anlaşılamaz hale gelir.Bunun okunmasını kolaylaştırmak istiyoruz. o yüzden bu metodu enuma çeviriyoruz.
        }
    }
}
