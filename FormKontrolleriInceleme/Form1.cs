using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (Control item in this.Controls)
            //{
            //    MessageBox.Show(item.Name);
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
          DialogResult resultEnum =  MessageBox.Show("Temizlemek istediğinize emin misiniz? ", "Onay Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultEnum == DialogResult.Yes)
            {
                // FormTemizle();
                FormElemanIndexTemizle();

            }
            else
            {
                //işlem iptal edildi
            }
        }
        private void FormElemanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmail"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelNo"]).Text = string.Empty;


        }
        private void FormTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) //item control == TextBox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty; //form üzerindeki textbox boşaltılır.
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //sanaldb içerisine kakyıt işlemi olacak
            sanalDatabase.KullaniciTablo.Add(new kullanici
            {
                Isim = txtIsim.Text,
                Soyisim=txtSoyisim.Text,
                Email = txtEmail.Text,
                TelNo = txtTelNo.Text
            });
            
            FormTemizle();
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit frmOnizleme = new frmOnizlemeKayit();
            ((TextBox)frmOnizleme.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)frmOnizleme.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)frmOnizleme.Controls["txtEmail"]).Text = txtEmail.Text;
            ((TextBox)frmOnizleme.Controls["txtTelNo"]).Text = txtTelNo.Text;

            frmOnizleme.ShowDialog();
        }
    }
}
