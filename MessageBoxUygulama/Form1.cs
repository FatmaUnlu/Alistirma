using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = sanalDatabase.musteriler;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
           int islemSonuc= YeniMusteriEkle(new Musteri()
            {
                Id=Guid.NewGuid(),
                Isim = txtIsim.Text,
                Soyisim = txtSoyisim.Text,
                EmailAdres=txtEmailAdres.Text,
                TelNo=txtTelNo.Text
            });

            if (islemSonuc>0)
            {
              DialogResult res =  MessageBox.Show("Müşteri ekleme işlemi başarılı,yeni müşteri kaydı yapmak ister misiniz ", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam müşteri kayıt sayısı" + sanalDatabase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Müşteri adet bilgisi ";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                    
                }
                else if (res==DialogResult.No)
                {
                    
                }
                Ekrantemizle();
                EkranListele();
            }
            
            else
            {
                MessageBox.Show("Hata: Kayıt ekleme işlemi yapılamadı");
            }
            
        }

        private void EkranListele()
        {
           // lstMusteriler.Items.Add(sanalDatabase.musteriler);
            lstMusteriler.DataSource = bs;
            bs.ResetBindings(false);


        }
        private void Ekrantemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txtEmailAdres.Text = string.Empty;
            txtTelNo.Text = string.Empty;
        }
        private int YeniMusteriEkle(Musteri data)
        {
            sanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
