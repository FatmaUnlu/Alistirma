using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //items.add metodu kullanılarak değerler comboboxa eklendi
            //ComboboxDoldurV1();
            ComboboxDoldurV2();
        }
        private void ComboboxDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }
        private void ComboboxDoldurV2()
        {
            cmbUrunListe.DataSource = database.UrunTablo;
        }
        private Urun seciliUrun;
        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Yöntem
            seciliUrun = (Urun)cmbUrunListe.SelectedItem;

            //object o = cmbUrunListe.SelectedItem;
            //Urun u1 = (Urun)o;
            //u1 = cmbUrunListe.SelectedItem == null ? null : cmbUrunListe.SelectedItem as Urun;

            //2.yöntem
            //ComboBox secilenCombobox = sender as ComboBox;
            //1.yöntem eğer form içeriside bulunan form elemanına özel bir metoda 
            //yazıldı ise o zaman ilgili form elemanını direkt olarak çağırmak daha mantıklıdır.

            //2.yöntem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine
            //tıklandığına veya işlem yapıldığını bilmediğimiz için ve metodumuz birden fazla form 
            //elemanında olay metodu olarak tanımlandıgı için biz senderüzerinden gelen nesneeyi
            //kullanır.Kullanıcının hangi form elemanında işlem yapmış oldugun anlarız
            pbUrunResim.Image = Image.FromFile(seciliUrun.UrunResim);
            pbUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAd.Text = seciliUrun.UrunAdi;
            txtYazar.Text = seciliUrun.Yazar;
            txtKategori.Text = seciliUrun.UrunKategori;
            txtStokAdet.Text = seciliUrun.StokAdet.ToString();
            txtUrunAciklama.Text = seciliUrun.Aciklama;
        }
    }
}
