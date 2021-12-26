using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass___2
{
    public class GenericRepository <T> where T : class // T tipi class olmalı şartı where ile sağlanır.Örneğin bir int değeri girilemez.
        //datayı sql e taşıyacak olan operasyonel bir class 

    {
        public GenericRepository()
        {
            //context : EF DB First
            //yapıcı metot database ile bağlantı kuracak 
        }
        public virtual List<T> Getir() //IEnumarable interface inden data dönen Getir fonk
        {
            //Gelen T tipini db üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic
            //koleksiyon olarak bir üst katmana dönmek
            return null; 
        }
        public virtual void yeniKayitEkle(T data)
        {
            //gelen T tipi içerisinideki bilgi T tipinin işaret ettiği tbloya eklenir
        }


    }
}
