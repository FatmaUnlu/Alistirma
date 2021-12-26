using System;

namespace AbstractNedir
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TemelSinif T1 = new TemelSinif();
            Musteri M1 = new Musteri();
             M1.Test();
            M1.testAbstract();

            MsuperMusteri S1 = new MsuperMusteri();
            S1.testAbstract();

        }
    }
}
