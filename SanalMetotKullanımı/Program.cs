using System;

namespace SanalMetotKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.ekranaYaz("Hangi metot çalışacak");

            Urün urn = new Urün();
            urn.ekranaYaz("Urun nesnesi içerisinden bu metot çağrıldı");

            BaseClass B1 = new BaseClass();
            B1.ekranaYaz("baseclass içerisinden bu metot çağrıldı");
        }
    }
}
