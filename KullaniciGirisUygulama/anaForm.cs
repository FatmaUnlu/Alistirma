using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisUygulama
{
    public partial class anaForm : Form
    {
        public anaForm(kullanici bulunanKullanici)
        {
            InitializeComponent();
            txtIsim.Text= bulunanKullanici.Isim;
            txtSoyisim.Text = bulunanKullanici.Soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.KullaniciAdi;
            txtKullaniciAdi.Enabled = false;
            txtSifre.Text = bulunanKullanici.Sifre;
            txtAciklama.Text = bulunanKullanici.Aciklama;
            btnGuncelle.Tag = bulunanKullanici.Id; //ıd yi içinde tutar. Bu özellik sayesinde başka bir formdan erişim sağlayabiliriz.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Button btnGuncelle = (Button)sender;
            int id = (int) btnGuncelle.Tag;
            //id değerine ulaştık. Buna göre kullanıcı bilgilerine erişelim.
            int index = sanalDatabase.KullaniciTablo.FindIndex(i => i.Id == id);
            sanalDatabase.KullaniciTablo[index].Isim = txtIsim.Text;
            sanalDatabase.KullaniciTablo[index].Soyisim = txtSoyisim.Text;
            sanalDatabase.KullaniciTablo[index].Sifre = txtSifre.Text;
            sanalDatabase.KullaniciTablo[index].Aciklama = txtAciklama.Text;

        }
    }
}
