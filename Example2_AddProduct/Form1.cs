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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjectContext db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
            txtPassword.PasswordChar = '*';
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(db.Users.FirstOrDefault(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text) != null)
            {
                Form2 form2 = new Form2(this);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parolayı yanlış girdiniz! Lütfen tekrar deneyiniz.");
                txtUserName.Text = txtPassword.Text = "";
            };
        }
    }
}
