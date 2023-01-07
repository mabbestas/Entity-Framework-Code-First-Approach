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
    public partial class Form2 : Form
    {
        public Form2(Form1 form1)
        {
            InitializeComponent();          
        }

        ProjectContext db;
        private void Form2_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();

            KategorileriDoldur();
        }

        private void KategorileriDoldur()
        {
            lstCategories.Items.Clear();

            List<Category> aktifKategoriler = db.Categories.Where(x => x.IsActive == true).ToList();

            foreach(var item in aktifKategoriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Description);

                lstCategories.Items.Add(lvi);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen kategori adını giriniz!");
            }
            else
            {
                Category eklenenKategori = new Category();
                eklenenKategori.Name = txtCategoryName.Text;
                eklenenKategori.Description = txtCategoryDescription.Text;
                eklenenKategori.IsActive = true;
                eklenenKategori.AddedDate = DateTime.Now;

                db.Categories.Add(eklenenKategori);
                db.SaveChanges();

                KategorileriDoldur();

                txtCategoryName.Text = txtCategoryDescription.Text = "";
                MessageBox.Show("Kategori başarıyla eklendi!");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }
    }
}
