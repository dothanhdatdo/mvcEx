namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 2048),
                        ParentId = c.Guid(),
                        SiteId = c.Guid(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Guid(),
                        Status = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UrlName = c.String(maxLength: 256),
                        Title = c.String(nullable: false, maxLength: 256),
                        Sku = c.String(),
                        PublicationDate = c.DateTime(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        View = c.Int(nullable: false),
                        Keyword = c.String(maxLength: 256),
                        ExpotationDate = c.DateTime(),
                        Description = c.String(),
                        ShortDescription = c.String(maxLength: 2048),
                        Weight = c.Double(),
                        Height = c.Double(),
                        Width = c.Double(),
                        Depth = c.Double(),
                        CategoryId = c.Guid(),
                        SupplierId = c.Guid(),
                        ManufacturerId = c.Guid(),
                        StatusId = c.Guid(),
                        SiteId = c.Guid(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Guid(),
                        Status = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.CategoryId)
                .Index(t => t.SupplierId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        CodeName = c.String(maxLength: 250),
                        Description = c.String(),
                        Website = c.String(maxLength: 250),
                        LogoPath = c.String(),
                        SiteId = c.Guid(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Guid(),
                        Status = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 250),
                        CodeName = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 200),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Fax = c.String(maxLength: 50),
                        Id = c.Guid(nullable: false),
                        SiteId = c.Guid(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Guid(),
                        Status = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
