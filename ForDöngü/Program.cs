using System;

namespace ForDöngü
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for genel kullanım
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ben bir for döngüsüyüm");
            }
            #endregion
            Console.Clear();
            #region ekran üzerinde 1-10 arasındaki değerleri yazdıralım.

            for (int i = 1; i<=10; i++ )
            {
                Console.WriteLine(i +".tekrar !");
            }
            #endregion
            Console.Clear();
            #region ekran üzerinde 1-100 arasındaki çiftdeğerleri yazdıralım.

            //for (int sayac = 2; sayac <= 100; sayac=sayac+2)
            //{
            //    Console.WriteLine(i);
            //}
            //int toplam = 0; 
            //for (int sayac = 0; sayac < 100; sayac++)
            //{
            //    if(sayac%2==0)
            //    {
            //        Console.WriteLine(sayac + " çift sayidir");
            //        toplam = toplam + sayac; //toplam+=sayac;

            //    }
            //}
            //Console.WriteLine("0-100 arası çift sayıların toplamı: " + toplam);
            #endregion
            //Console.Clear();

            #region kullanıcı ekran üzerinden bir sayı girişi yapacak.Girilen sayının faktöriel hesabını alıp ekrana yazdır.

            //Console.WriteLine("faktöriyeli alınacak sayıyı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktöriyel =1;
            //for ( int a= 1; a<=sayi; a++)
            //{
            //    faktöriyel = a * faktöriyel;
            //}
            //Console.WriteLine(faktöriyel);

            //for(int a = sayi; a>1; a--)
            //{
            //    faktöriyel = a * faktöriyel;
            //}
            //Console.WriteLine(faktöriyel);
            #endregion
            //Console.Clear();

            #region sonsuz döngü oluşturmak 
            //for döngüsünde sonsuz deöngü yapalım. bir şarta bağlı olmasın işlemler
            //int sonsuzDöngüSayac = 0; 
            // for(; ; )
            //{
            //    sonsuzDöngüSayac++;
            //    //if(sonsuzDöngüSayac == 2)

            //    //    break;
            //    if (sonsuzDöngüSayac == 2)

            //        continue;
            //    Console.WriteLine(sonsuzDöngüSayac);
            //    Console.WriteLine(" Ben bir sonsuz döngüyüm");
            //}
            #endregion

            #region iç içe for döngüsü
            //for(int i = 0; i<20; i++)
            //{
            //    for(int j=0; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Çarpım tablosu 
            int sonuc = 0;
            for( int k=1; k<=9; k++)
            {
                for (int l = 1; l <= 9 ; l++)
                   
                {
                    sonuc = k * l;
                     //Console.WriteLine(  k + "*" +  l  + "=" + sonuc ); 
                    Console.Write("{0}*{1}={2}\t" , k,l,sonuc);

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            #endregion




        }
    }
}
