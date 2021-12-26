using System;
using System.Collections;

namespace QueueGenelKullannım
{
    class Program
    {
        static void Main(string[] args)
        {
            //son giren ilk çıkar
            Queue q1 = new Queue();
            q1.Enqueue("Bir");  //içeri obje ekleme
            q1.Enqueue("İki");
            q1.Enqueue("Üç");
            q1.Enqueue("Dört");

            object o2 = q1.Peek(); //ön gösterim yapar
            object o1 = q1.Dequeue(); // göderim yaptıktan sonra veriyi siler 
            

        }
    }
}
