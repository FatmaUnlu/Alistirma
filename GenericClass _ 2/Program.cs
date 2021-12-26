using System;
using System.Collections.Generic;

namespace GenericClass___2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Db      | Uygulama
             * Mysql  | c #
             * 
             * tblMusteri 
             * id int
             * musteriNo uniqueidentyfy (guid)
             * isim nvarchar string
             * soyisim nvarchar string
             * dogumtarih datetime
             * 
             * unitOfWorks => Generic class Generic interface
             * 
             */

            GenericRepository<Musteri> repositoryMusteri = new GenericRepository<Musteri>();
            List<Musteri> musterilerim = repositoryMusteri.Getir();

            //genericrepository Musteri tipinde bir nesne oluşturuldu ve bununla birlikte içerisindeki tüm metotlar 
            //müşteri tablosu üzerinde işlem yapabilen metotlar yığını haline gelir. Gerçek hayatta bu şekilde kullanılır. 

            repositoryMusteri.yeniKayitEkle(null);

            GenericRepository<Urun> repositoryUrun = new GenericRepository<Urun>();
            List<Urun> urunlerim = repositoryUrun.Getir();//Urun tablosundan kayıtları list generic olarak getir 

            repositoryUrun.yeniKayitEkle(null);
        }
    }
}
