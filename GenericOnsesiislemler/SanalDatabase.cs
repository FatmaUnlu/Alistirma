using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOnsesiislemler
{
    public class  SanalDatabase
    {
        private ArrayList listem;
        public SanalDatabase()
        {
            listem = new ArrayList();
        }

        public void YeniKayit(int data)
        {
            listem.Add(data);
        }

    }
}
