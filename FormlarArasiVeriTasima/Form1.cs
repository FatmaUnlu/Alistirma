using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMesaj.Text = "Metin Giriniz : ";
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            //MUsteri m1 = new Musteri();

            string txtMesajDegeri = txtMesaj.Text;

            Form2 frm2 = new Form2(txtMesajDegeri);
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMesaj_Enter(object sender, EventArgs e) //sender yakalamak istediğim textboxı referans eder
        {
            TextBox T1 = (TextBox)sender; //formun üzrindeki textbox t1 ile yakalanır.
            T1.Text = string.Empty;
        }
    }
}
