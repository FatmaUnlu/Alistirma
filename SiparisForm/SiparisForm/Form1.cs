using SiparisForm.Models;
using SiparisForm.ViewModels;

namespace SiparisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindYeniContext _dbContext = new NorthwindYeniContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
             //lstProducts.DataSource = _dbContext.Products.OrderBy(x=> x.ProductName).ToList();
            lstProducts.DataSource = UrunAra();

            cmbCustomer.DataSource = _dbContext.Customers
                .OrderBy(x => x.CompanyName)
                .ToList();
            cmbCustomer.DisplayMember = "CompanyName";

            cmbEmployee.DataSource = _dbContext.Employees
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            cmbShippers.DataSource = _dbContext.Shippers
                .OrderBy(x => x.CompanyName)
                .ToList();
            cmbShippers.DisplayMember = "CompanyName";
        }

        private List<Product> UrunAra(Func<Product,bool> predicate= null)
        {
          return predicate == null ? _dbContext.Products.OrderBy(x=> x.ProductName).ToList() : _dbContext.Products.Where(predicate).OrderBy(x=> x.ProductName).ToList();
        }

        private List<SepetViewModel> _sepet = new List<SepetViewModel>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null) return;
            var urun = lstProducts.SelectedItem as Product;
               var sepetUrun= _sepet.FirstOrDefault(x=> x.Urun.ProductId == urun.ProductId);

            if (sepetUrun==null)
            {
                _sepet.Add(new SepetViewModel
                {
                    Urun = urun,
                    Adet = 1

                }); ;              
            }
            else
            {
                sepetUrun.Adet++;
            }
            SepetiDoldur();
        }

        private void SepetiDoldur()
        {
            var toplam = _sepet.Sum(x => x.AraToplam);
            lblToplam.Text = $"Toplam: {toplam}";

            lstCart.Columns.Clear();
            lstCart.Items.Clear();
            lstCart.MultiSelect = false;
            lstCart.FullRowSelect = true;
            lstCart.View = View.Details;

            lstCart.Columns.Add ("Ürün") ;
            lstCart.Columns.Add("Adet");
            lstCart.Columns.Add("Toplam Fiyat");

            foreach (var item in _sepet)
            {
                ListViewItem viewitem = new ListViewItem(item.Urun.ProductName.ToString());
                viewitem.Tag = item;
                viewitem.SubItems.Add(item.Adet.ToString());
                viewitem.SubItems.Add(item.AraToplam.ToString());
                lstCart.Items.Add(viewitem);
            }

            
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string text = txtAra.Text.ToLower();
            lstProducts.DataSource=UrunAra(x=>x.ProductName.ToLower().Contains(text));
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnArttýr_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
          
        }
    }
}