using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikFormElemanları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
        }

        int mayin1 = 0;
        int mayin2 = 0;
        int mayin3 = 0;
        Random rnd = new Random();
       
        private void btnUret_Click(object sender, EventArgs e)
        {
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 1; i <= 50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;

                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }

                btnTemp.Click += btnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);

            }
        }
        private void btnTemp_Click(object sender, EventArgs e)
        {
            //Eğer  3 kez mayına basıldı ise form üzerinde bulunan tüm butonları pasif edin
            //Uygulama bitti şeklinde bir mesaj versin.

            Button basiliButton = (Button)sender;
            bool mayinBulundumu = (bool)basiliButton.Tag;

            int mayinInt = int.Parse(lblMayin.Text);

            if (mayinBulundumu)
            {
                MessageBox.Show("Mayını buldunuz");
                basiliButton.BackColor = Color.Red;
                mayinInt++;
                lblMayin.Text = mayinInt.ToString();
               
            }
            else
            {
                basiliButton.BackColor = Color.Green;
                int skorInt = int.Parse(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString();
            }
            if (mayinInt >= 3)
            {
                MessageBox.Show("Oyun Bitti");
                this.Hide();                 
            }
        }


    }
}


    

