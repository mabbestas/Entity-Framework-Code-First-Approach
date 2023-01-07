namespace Example2_AddProduct.Migrations
{
    using Example2_AddProduct.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Example2_AddProduct.Entity.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Example2_AddProduct.Entity.ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Category category = new Category();
            category.Name = "Elektronik";
            category.IsActive = true;
            category.Description = "Elektronik ürünler";
            category.AddedDate = DateTime.Now;

            context.Categories.Add(category);

            context.SaveChanges();
        }
    }
}
