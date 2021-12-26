using System;
using System.Collections;

namespace StackGenelKullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            //last in first out  davranış şekline sahiptir. Data üzerinde işlem yapacağımız zaman en son elemandan başlar. En son giren data ilk işlem görüp önce çıkar.
            Stack stackUygulama = new Stack();

            stackUygulama.Push("Bir"); //push ile datalar eklenir.
            stackUygulama.Push("iki");
            stackUygulama.Push("üç");
            stackUygulama.Push("Dört");

            // içinde tuttukları değerleri object tipinde dönerler
            object o1 = stackUygulama.Pop(); //datayı göderiyo ama koleksiyondan kaldırmıyı. ön gösterim gibi düşünün
            object o2 =stackUygulama.Peek(); //datayı gönderip işlemden kaldırıyo







        }
    }
}
