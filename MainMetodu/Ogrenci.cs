using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarGenelKullanım
{
    public class Ogrenci
    {
        public void SelamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci");
            // [Erişim Belirleyicisi] <Geri Dönüş Değeri> Metot adı (parametreler)
            //{ 
            // Metot için gereken kodlar
            // }

            //public :bu metodu benim clasıma ulaşan herkesin bu metoda ulaşabilmesini sağlamak için kullaılır
            //private .içinde bulunmuş olduğu clas düzeyinde çağrılabilir. 
            //internal : İlgili kütüphane içinde (proje içinde metoda ulaşabilirsin)
            //protected : birbirinden nesneler kalıtıldığında protected olarak kullanılır
            //internal protected


        }

        public void OgrenciMetot1 (string ögrenciAdı, string ögrenciSoyadi) //private olsa programcs den erişemeyiz. sadece bu classta ögrenci sınıfında erişebilriz.
        {
            Console.WriteLine($"Öğrenci bilgileri : {ögrenciAdı} {ögrenciSoyadi}");
        }
        
    }
}
