namespace Example2_AddProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iki : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AppUsers", newName: "Users");
            AlterColumn("dbo.Categories", "Description", c => c.String(maxLength: 255));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "AddedDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "AddedDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "AddedDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            CreateIndex("dbo.Products", "CategoryID");
            AddForeignKey("dbo.Products", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            AlterColumn("dbo.Users", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Products", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Categories", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            RenameTable(name: "dbo.Users", newName: "AppUsers");
        }
    }
}
