using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxUygulama
{
    public class database
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun () {Id = 1 , UrunAdi="bir ömür nasıl yaşanır" , StokAdet=10 , UrunKategori="Roman", Aciklama="kldmfkldnjgnjkdfbgsdbgskjb", Yazar="ilber ortaylı" },
            new Urun() { Id = 2 , UrunAdi = "Metastaz" , StokAdet = 15 , UrunKategori = "Roman", Aciklama = "wertyuıopğişlkjhgfdsxcvbnmöç", Yazar = "Barış Pehlivan" },
            new Urun() { Id = 3 , UrunAdi = "Şeker Portakalı" , StokAdet = 12 , UrunKategori = "Roman", Aciklama = "üğşçömkoıjhuygvftrdxse", Yazar = "Jose Mourınho" },


        };
    }
}
