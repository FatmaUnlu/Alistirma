using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            string[] isimler = new[] { "fatma ünlü", "ali koç", "sevgi alkan", "muhammet gürbüz", "fatmagül polat" };
            foreach (string item in isimler)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region örnek uygulamalar

            #endregion
        }
    }
}
