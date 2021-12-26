using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
   public static class SanalDatabase
    {
        private static ArrayList db = new ArrayList(); //dışarıdan set edilemesin manipüle edilemesin diye. Örnekleme yapmasaydık hata verecekti. ben db nesnesini kullanıma açmış olmayacaktım.


        public static void YeniUrünEkle(BaseClass data) //BaseClasstan üreyen tüm nesneleri içerir. Ürün deseydim üründen türeyen nesneleri içerirdi.
        {
            //db içine eklemek istediğim ürünün barkodu varsa ekleme yapılmıcak
            if (data != null && !string.IsNullOrEmpty(data.Barkod)) //data değeri null değilse ve data nın barkodu boş ya da null değilse
            {
                db.Add(data);
            }
        }

        
        public static bool DbBarkodKontrol (string barkod)
        {
            bool Kontrolİslemi = false;
            if (db != null && db.Count>0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    BaseClass bc = (BaseClass)db[i];
                    if (bc.Barkod == barkod)
                    {
                        return Kontrolİslemi= true;
                    }
                }
            }
            return Kontrolİslemi;
        }
    }
}
