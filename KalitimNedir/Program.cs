using System;

namespace KalitimNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eğitmen E1 = new Eğitmen(); //egitmen nesnesi örnekleniyor burda.instance alınıyor.
            //E1.TemelTipMetot1(); // Egitmenden türetilen nesne ile basetypetaki Temelmetot1 e erişebilirim
            //Console.WriteLine("Eğitmen nesnesi örneklendi.");

            //BaseType bt = new BaseType();
            //bt.TemelTipMetot1();

            ////Özel Tiplerde Boxing Unboxing işlemleri

            ////object nesnemiz nedir(yani hepsiyle uyumlu olan ve hepsini kabul eden)? Temel Tip (BAseType)
            //BaseType T2;
            ////hangi nesnelerde basetype object görevi görür?Personel,eğitmen, öğrenci. Çünkü basetype nesnesinden türedikleri için basetype nesnesi bu nesnelerde object gibi davranır

            //T2 = E1;//Eğitmen nesnesini Basetype nesnesine atadık .Hata vermedi. 
            //Personel P1 = new Personel();
            //T2 = P1; //Personel nesnesini Basetype nesnesine atadık .Hata vermedi. 
            //P1 = (Personel)T2; //unboxing

            //Ogrenci o1 = new Ogrenci();
            //T2 = o1;

            //o1 = (Ogrenci)T2; //unboxing

            //object o3 = T2;

            //Boxing ve Unboxing

            //object o1 = E1; //boxing
            //E1 = (Eğitmen)o1; //unboxing

            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci o1 = new Ogrenci();
            //o1.TemelTipMetot1();

            //object obj1 = o1;
            //o1 = (Ogrenci)obj1;

            //obj1 = P1; //boxing
            //P1 = (Personel)obj1; //unboxing

            //Test Tst1 = new Test();
            //Tst1.
            //hangi nesnemizin kalıtılmasını istemiyoruz? Eğitmen clasını  sealed olarak nitelendirmeliyiz bunun için 


            //Eğitmen nesnesini personelden kalıttıktan sonra
            Eğitmen E1 = new Eğitmen();
            
            //Eğitmen = >Personel => Basetype => Object
            //Object=> BaseType =>Personel=> Egitmen : kalıtım sırası

            //public: uygulamamızın içinde veya dışında ulaşılabilir anlamını taşır
            //private: Sadece tanımlandığı class içerisinde erişilebilir olur.
            //protected: mormal kullanımda private olarak davranır. Ama oluşturduğum class kalıtılırsa kalıtım alınan classta public olarak kullanılabilir.
        }
    }
}
