using System;
using System.Collections;

namespace GenericOnsesiislemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Liste sadece int değerler alınsın istiyorum diyelim.Çünkü yapısı gereği tüm tipleri içine kabul edebilir aynı anda. (SanalDatabase klasöründe)

            //ArrayList lst = new ArrayList();
            //lst.Add();
            SanalDatabase sDb = new SanalDatabase();
            sDb.YeniKayit(1);
            sDb.YeniKayit(2);
        }
    }
}
