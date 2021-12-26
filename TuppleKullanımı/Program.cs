using System;

namespace TuppleKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple” aynı veya farklı tipten birden fazla elemanı içerebilen bir veri yapısıdır.
            //Aslında bu tanıma baktığımızda bize “class” tanımını çağrıştırıyor gibi görünebilir.
            //“Tuple” veri yapısı sayesinde yeni bir “class” yaratmadan da birden fazla tipteki elemanı
            //aynı veri yapısı içerisinde tutabiliyoruz.

            //Tuple” veri yapısını nasıl kullanılır? 
            Tuple<string, string, int, string> personInformation = new Tuple<string, string, int, string>("fatma", "yüsra", 7, "ayse");
            //ya da 
            Tuple<string, int> companyInfornatiion = Tuple.Create("wissen", 6); //Tuple” tipinden bir değişke oluşturma


            //Yukarıdaki kod parçasını okumak ve anlamlandırmak oldukça zor. “personInformation” tipindeki 3.özellik olan “5” sayısı
            //neyi simgeliyor sorusuna yukarıdaki kod parçası cevap veremiyor.“Tuple” içinde tutulan değişkenlerin neyi simgelediğinin yazılmasıgerekiyor kod okunurluğu için.
            //yorum satırı ile üst kısımlara

            //C# dil desteği olarak bir “Tuple” tipinde 8 özellik tutabilmemize imkan sağlıyor. 8'den fazla tutmak istiyorsak 
            //    Tuple içinde Tuple gibi çabalar ile bu sayıyı arttırabiliriz


            //“Tuple” değişkeninin özelliklerine ulaşabilmek için de “değişken adı . item1,2,3..” şeklinde bir kod yazmamız gerekiyor.

            var experience = personInformation.Item3;
            var numberOfEmployee = companyInfornatiion.Item2;



        }
        // “Tuple” bir veri yapısı olduğu için methodlardan sonuç olarak döndürülebilir.
        private Tuple<string, string, int, string> GetPersonInformatıonFrpmDatabaseId(int personId)
        {
            return new Tuple<string, string, int, string>("İbrahim", "Seçkin", 8, "Fatma");

        }

        //“Tuple” tipi aynı zamanda methodlara parametre olarak da geçirilebilir.

        public void Method3(Tuple<string, string, int, string> personInformation)
        {

        }

        //Bu methodu çağıran kod parçası, methodun dönüş değerini kullanmak istediğinde daha önce gösterdiğimiz
        //gibi “değişken adı . item1,2,3..” diyerek kullanabiliyor.

        //c# 7 ile gelen özellikler sayeside şu sıkıntılardan kurtulunmuştur
        /*Tuple” tipindeki özelliklere isim veremediğimiz için sürekli olarak Item1,2.. şeklinde ulaşmamız 
         * gerekiyor. Bu sebeple de “Tuple” kullanımında kod okunabilirliği azalıyor.
         *Yukarıda bahsetmediğimiz ikinci bir dezavantaj da olası performans dezavantajı. C#4.0 ile gelen “Tuple”
         *veri yapısı, referans tipinde bir yapı olduğu için memory’nin “heap” kısmında saklanıyor. Bu sebeple kullanımı 
         *bittiği zaman “garbage collector” dediğimiz yapı “Tuple” tipindeki değişkenleri silmeye çalışıyor. 
         *“Garbage collector” çalışma mekanizması ekstra bir performans yükü getirdiği için, performansın 
         *önemli olduğu uygulamalarda sıkıntı yaratabilir.
         */

        /*Öncelikle performans kısmına değinelim. C#7 ile gelen yeni “Tuple” değer tipinde bir yapı olduğu için 
         * memory’nin “stack” dediğimiz kısmında tutuluyor ve “Garbage Collector” mekanizmasını çalıştırmadığı 
         * için performans olarak bir avantaj sağlayabilir.       
         */

        //“Tuple” veri yapısını çoğunlukla methodlardan birden fazla sonuç dönebilmek için kullandığımızı söylemiştik.


        //c#7 tuple kullanımı şu şekildedir.

        //public void getPersonInformationById(int PersonId)
        //{
        //    var PersonInformation = getPersonInformationFromDatabaseId(1);
        //    var isim = PersonInformation.isim;
        //    var soyİsim = PersonInformation.soyİsim;
        //    var tecrübe = PersonInformation.tecrübe;
        //    var pozisyon = PersonInformation.tecrübe;



        //}

        //private (string isim, string soyisim, int tecrübe, string pozisyon) getPersonInformationFromDatabaseId(int PersonId)
        //{
        //    return ("İbrahim" , "seçkin", 5, "developer") ;
        //}
        
        //ya da

        public void getPersonInformationById(int PersonId)
        {
            (string isim, string soyisim, int tecrübe, string pozisyon) PersonInformation = getPersonInformationFromDatabaseId(1);

        }

        private (string, string, int, string) getPersonInformationFromDatabaseId(int PersonId)
        {
            return ("İbrahim", "seçkin", 5, "developer");
        }

    }
}
