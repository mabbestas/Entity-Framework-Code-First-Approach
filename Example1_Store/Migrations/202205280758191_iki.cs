namespace Example1_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iki : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Products", "StoreID");
            AddForeignKey("dbo.Products", "StoreID", "dbo.Stores", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "StoreID", "dbo.Stores");
            DropIndex("dbo.Products", new[] { "StoreID" });
        }
    }
}
