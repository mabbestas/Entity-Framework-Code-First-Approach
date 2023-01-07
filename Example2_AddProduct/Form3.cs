using Example2_AddProduct.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2_AddProduct
{
    public partial class Form3 : Form
    {
        Form2 frm;
        public Form3(Form2 from2)
        {
            frm = from2;
            InitializeComponent();
        }

        ProjectContext db;
        private void Form3_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
            UrunleriDoldur();
            KategorileriDoldur();
        }

        private void KategorileriDoldur()
        {
            cmbKategoriler.DataSource = db.Categories.Where(x => x.IsActive).ToList();
            cmbKategoriler.DisplayMember = "Name";
            cmbKategoriler.ValueMember = "ID";  // cmbKategoriler.SelectedValue property'sinden CategoryId ye ulaşabiliriz.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Products eklenenProducts = new Products();
            eklenenProducts.Name = txtUrunAdi.Text;
            eklenenProducts.UnitPrice = nmrBirim.Value;
            eklenenProducts.UnitInStock = Convert.ToInt16(nmrStok.Value);
            eklenenProducts.IsActive = true;
            eklenenProducts.AddedDate = DateTime.Now;
            eklenenProducts.CategoryID = Convert.ToInt32(cmbKategoriler.SelectedValue);
            

            db.Products.Add(eklenenProducts);
            db.SaveChanges();

            UrunleriDoldur();


            txtUrunAdi.Text = "";
            nmrBirim.Value = 0;
            nmrStok.Value = 0;
        }

        private void UrunleriDoldur()
        {
            lstProducts.Items.Clear();

            List<Products> activeProducts = db.Products.Where(x => x.IsActive == true).ToList();

            foreach(var item in activeProducts)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Category.Name);
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.UnitPrice.ToString());
                lvi.SubItems.Add(item.UnitInStock.ToString());

                lvi.Tag = item;

                lstProducts.Items.Add(lvi);
            }




            //lstCategories.Items.Clear();

            //List<Category> aktifKategoriler = db.Categories.Where(x => x.IsActive == true).ToList();

            //foreach (var item in aktifKategoriler)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.Text = item.ID.ToString();
            //    lvi.SubItems.Add(item.Name);
            //    lvi.SubItems.Add(item.Description);

            //    lstCategories.Items.Add(lvi);
            //}
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }

        Products guncellenecek;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count <= 0)
                return;

            guncellenecek = lstProducts.SelectedItems[0].Tag as Products;
            cmbKategoriler.SelectedItem = guncellenecek.Category.Name;
            guncellenecek.Name = txtUrunAdi.Text;
            guncellenecek.UnitPrice = Convert.ToInt32(nmrBirim.Value);
            guncellenecek.UnitInStock = Convert.ToInt16(nmrStok.Value);

            db.Products.Add(guncellenecek);
            db.SaveChanges();

            UrunleriDoldur();

            txtUrunAdi.Text = "";
            nmrBirim.Value = 0;
            nmrStok.Value = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {           
            Products silinecek = lstProducts.SelectedItems[0].Tag as Products;

            db.Products.Remove(silinecek);           
            db.SaveChanges();

            UrunleriDoldur();

        }
    }
}
