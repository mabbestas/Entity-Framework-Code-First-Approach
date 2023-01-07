using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_AddProduct.Entity
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database=ProductsDb; Trusted_Connection=True";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<AppUser> Users { get; set; }

    }
}
