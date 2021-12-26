using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir
{
   public class MusteriGeneric <T> //bu class örneklenmek istendiğinde T tipi(burada T yazıldığığ için.başka bişey de olabilir.) belirtilmek zorundadır. 
    {
        public T Id { get; set; }
        public  T MusteriNumara { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DogumTarih { get; set; }
        public T MusteriNumaarasıAl()
        {
            return MusteriNumara;
        }
            
    }
}
