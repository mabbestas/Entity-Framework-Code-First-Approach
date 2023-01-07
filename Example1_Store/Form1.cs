using Example1_Store.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1_Store
{
    public partial class Form1 : Form
    {

        /* 1. References'a Nuget üzerinden Entity Framwork ekleyeceğiz.
         * EF, EF.SqlServer, System.ComponentModel.DataAnnotaions 
         * 
         * 2. Entity klasörü oluşturdum.
         *    Entit classlarımı yazdım.
         *    
         * 3. Context class'ı oluşturacağız.
         * DbContext'en miras alıyoruz.
         * using System.Data.Entity yaparak ekledik.
         * 
         * 4. DbSet ekledik. Veritabanında oluşmasını istediğim tabloların karşılığını ekliyorum.
         * 
         * 5. Ctor ile constactor çıkardık. içine alt satırı ekledik.
         * @"Server=(localdb)\MSSQLLocalDB; Database=StoresDB; Trusted_Connection=True";  // Win Aut
         *
         * 6. Tools --> NuGet P.M. --> P.M. Console
         *    Migration yapmak istediğiniz projeyi seçiyorsunuz.  Default Project
         *    
         * 7. enable-migrations yazıp enter ladık ve klasörü oluşturduk.
         *    
         * 8. 'add-migration ilk' ile DB ile classlarımız arasındaki farkı buldu
         * 
         * 9. Update-database -- ile veri tabanını güncelledik
         * 
         * 10. Navigationsları yaz. (IEnumarable ya da list kullan!)
         */


        public Form1()
        {
            InitializeComponent();

            StoreContext db = new StoreContext();
        }
    }
}
