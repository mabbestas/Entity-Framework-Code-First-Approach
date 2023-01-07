using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Store.Entity
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {
            Database.Connection.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=StoreDb; Trusted_Connection=True";
        }

        public DbSet<Product> Urunler { get; set; }
        public DbSet<Store> Dukkanlar { get; set; }
    }
}
