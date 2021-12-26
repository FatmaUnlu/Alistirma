using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show_ShowDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.Show();
            //yeni form oluşturmak için kullanılır.Birden fazla kez tıklanabilir veya kullanıcı form acıkken uygulamanın diğer menülerine erişebilir
        }

        private void btnGosterPopup_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit();
            musteriKayit.ShowDialog();
            //kullanıcı bu şekilde form açtıgında ilgili form kapanmadan herhangi bir işlem yapamaz.
        }
    }
}
