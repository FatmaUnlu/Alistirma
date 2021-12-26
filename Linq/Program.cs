using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static bool funcDelegateKullanimi1(Musteri m)
        {
            if (m.Isim[0] == 'A')
                return true;
            else
                return false;
        }

        static bool predicateDelegeMethod(Musteri m)
        {
            if (m.DogumTarih.Year > 1990)
                return true;
            else
                return false;
        }

        static void musteriListele (Musteri m) //action method için
        {
            Console.WriteLine(m.Isim + " " + m.Soyisim);
        }

        static void Main(string[] args)
        {
           
            DataSource ds = new DataSource();
            List<Musteri> musteriListe = ds.musteriListesi();

            #region Başlarken

            //a ile başlayan müşteri isimlerini verin
            //int count = 0;
            //foreach (var item in musteriListe)
            //{
            //    if (item.Isim.Substring(0, 1) == "A")
            //    {
            //        string AlıIsimler = item.Isim;
            //        count++;
            //        Console.WriteLine(AlıIsimler);
            //    }
            //}
            //  Console.WriteLine($"Liste içerisinde adı A ile başlayan {count} kişi vardır");   

            int bulunanToplam = 0;
            for (int i = 0; i < musteriListe.Count; i++)
            {
                if (musteriListe[i].Isim[0] == 'A')
                    bulunanToplam++;

            }
            Console.WriteLine($"Liste içerisinde adı A ile başlayan {bulunanToplam} kişi vardır");
            Console.WriteLine(musteriListe.Count);


            //bunu Linq teknolojisi ile bunu çok kolay bir şekilde yapabiliriz. Esneklik sağlar.

            bulunanToplam = 0;
            bulunanToplam = musteriListe.Where(i => i.Isim.StartsWith("A")).Count();
            Console.WriteLine($"Liste içerisinde adı A ile başlayan {bulunanToplam} kişi vardır");

            #endregion

            #region Linq sorgulama çeşitleri
            //1.Yol: Linq işlemlerinin metotla sorgulanması
            int toplamMusteriAdet = musteriListe.Where(I => I.Isim.StartsWith("A")).Count();

            //2.Yol Linq to Query 
            var toplamMusteriAdet2 = from I in musteriListe //musteriListedeki her bir değeri I nesne örneği ile örnekle
                                     where I.Isim.StartsWith("A")
                                     select I; //I nesnesini seç
            int toplamMusteriAdetSon = toplamMusteriAdet2.Count();
            #endregion

            #region Alıştırmalar
            //1: musteriler içerisinde ülke değeri a ile başlayan müşterilerin sayısını linq to metotlar yöntemi ile bulma
            IEnumerable<Musteri> musteriListeAlistirma1 = musteriListe.Where(I => I.Ulke.StartsWith("A"));
            Console.WriteLine(musteriListeAlistirma1.Count());

            //Eğer bir metodun geri dönüş değeri IEnumarable ise sizin sorgunuz gitti çalıştı geldi, IQuarable ise sorgu hazırlanıyor daha gitmedi demektir. IQuarable da sorgular hazırlanır işin sonunda ne zaman o değeri çağıracaksak ozaman bizim sorgumuz data kaynağına gider sorguyu çeker ve getirir.

            //2: musteriler içerisindeki kayıtlardan isminin içerisinde b harfi geçen ve ülke değeri içinde a harfi geçen müşterilerin listesini getir.
            var musteriListeAlistirma2 = musteriListe.Where(I => I.Isim.ToLower().Contains("b") && I.Ulke.ToLower().Contains("a")).ToList();
            Console.WriteLine(musteriListeAlistirma2);

            //3: musteriler listesi içerisindeki kayıtlardan dogum yılı>1990 olan ve isminin içerisinde a harfi geçen müşterilerii linq to query yöntemi ile bulma 
            var musteriListeAlistirma3 = from I in musteriListe
                                         where I.DogumTarih.Year > 1990 && I.Isim.ToLower().Contains("a")
                                         select I;
            Console.WriteLine(musteriListeAlistirma3.Count());

            //4: musteriler listesi içerisindeki kayıtlardan dogum yılı>1990 olan veya isminin içerisinde a harfi geçen müşterilerii linq to query yöntemi ile bulma 

            var musteriListeAlistirma4 = from I in musteriListe
                                         where I.DogumTarih.Year > 1990 || I.Isim.ToLower().Contains("a")
                                         select I;
            Console.WriteLine(musteriListeAlistirma3.Count());


            #endregion

            #region Lİnq sorgularında delegate kullanımı - Func Delegate


            var delegateKullanimi1 = musteriListe.Where(I => I.Isim.StartsWith("A"));
            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);
            //lambda olmadan aynı sorguyu yapmak için Func delegesine ihtiyaç var. Müşteri tipinde ve geriye bool değeri dönen
            //müşteri listesinden değer alan ve geriye bool değeri dönen bir metota da ihtiyacımız var.Yukarıda tanmlıyoruz

            var delegateKullanimi2 = musteriListe.Where(funcDelegate1);
            //musteriliste.where mwtodu funcDelegate1'e gitti. funcDelegate1 metot imzasına uyan metotları gösterebilir ve şuan istenilene uygun
            //funcDelegateKullanimi1 metotu var.Ona yönlendirir ve müsteriListe deki her bir eleman bu metoda gider ve şart kontrol edilir Ale başlayanlar bulunur.
            //lambda ifadesi büyük bir yükten kurtarmış olur bizi.

            //Daha kısa olarak şu şekilde de yapabiliriz: Direkt delegenin işaret ettiği metot da verilebilir
            delegateKullanimi2 = musteriListe.Where(funcDelegateKullanimi1);

            //3. kullanımı şu şekilde gösterebiliriz. Where ve instance alma kısmı aynı anda yapılabilir
            var delegateKullanimi3 = musteriListe.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));
            //4. kullanımı şu şekilde gösterebiliriz. Func delegate delegateden kalıtıldığı için şu şekilde de yazılabilir. 
            var delegateKullanimi4 = musteriListe.Where(delegate (Musteri m) { return m.Isim[0] == 'A' ? true : false; });
            //5. kullanımı şu şekilde gösterebiliriz. Burada delegate yerine lambda kullanılabileceğini görüyoruz.
            var delegateKullanimi5 = musteriListe.Where((Musteri M) => { return M.Isim[0] == 'A' ? true : false; });
            //6. kullanımı şu şekilde gösterebiliriz. Tip belirtmesi de kaldırıldı burada
            var delegateKullanimi6 = musteriListe.Where((m) => { return m.Isim[0] == 'A' ? true : false; });
            // en kısa kullanımı ise şu şekilde. Lamda kullanımının hangi aşamalardan geldiğini inecelemiş olduk.Lambdanın
            // çözemeyeceği bir durum olduğunda yukarıdaki kullanımlar önemli olacak.
            var delegateKullanimi7 = musteriListe.Where(m => m.Isim[0] == 'A');


            #endregion

            #region Lİnq sorgularında delegate kullanımı - Predicate Delegate
            //Predicate delege geriye sadece boolean döner Func delege sadece boolen değil farklı tipler de dönebilir.

            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegeMethod);
            var delegateKullanimiPredicate1 = musteriListe.FindAll(predicate);

            var delegateKullanimiPredicate2 = musteriListe.FindAll(new Predicate<Musteri>(predicateDelegeMethod));

            var delegateKullanimiPredicate3 = musteriListe.FindAll(delegate (Musteri m) { return m.DogumTarih.Year > 1990; });

            var delegateKullanimiPredicate4 = musteriListe.FindAll((Musteri m) => { return m.DogumTarih.Year > 1990; });

            var delegateKullanimiPredicate5 = musteriListe.FindAll((m) => { return m.DogumTarih.Year > 1990; });

            var delegateKullanimiPredicate6 = musteriListe.FindAll(m => m.DogumTarih.Year > 1990);


            #endregion

            #region Lİnq sorgularında delegate kullanımı - Action Delegate
            //
            Action<Musteri> actionMusteri = new Action<Musteri>(musteriListele);
            musteriListe.ForEach(actionMusteri);
            //2.yol
            musteriListe.ForEach(new Action<Musteri>(musteriListele));
            //3.yol
            musteriListe.ForEach(delegate (Musteri m) { Console.WriteLine(m.Isim + " " + m.Soyisim); });
            //4.yol
            musteriListe.ForEach( (Musteri m) => { Console.WriteLine(m.Isim + " " + m.Soyisim); });
            //5.yol : En fazla buraya kadar kısaltılabilir. 
            musteriListe.ForEach((m) => { Console.WriteLine(m.Isim + " " + m.Soyisim); });



            #endregion

            #region Alıştırmalarla Linq  İnceleme
             // musteri listesi içerisinde bulunan kayıtlardan ismi a ile başlayan soyisim
             // değerinin içinde e olan ve doğum yılı 1985 ten büyük olan kayıtları getirin 
           
            var alistirma1 = from I in musteriListe
                             where
                             I.Isim.StartsWith("A") &&
                             I.Soyisim.Contains("e") &&
                             I.DogumTarih.Year > 1985
                             select I;

            Console.WriteLine(alistirma1.Count());

            var alistirma2 = musteriListe.Where(I => I.Isim.StartsWith("A") && I.Soyisim.Contains("e") && I.DogumTarih.Year > 1985).Select(I => I);

            Console.WriteLine(alistirma2.Count());

            #endregion










        }
    }
}
