namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebsiteDienThoai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Advs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 500),
                        Link = c.String(maxLength: 500),
                        Type = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        Position = c.Int(nullable: false),
                        SeoTitle = c.String(maxLength: 150),
                        SeoDescription = c.String(maxLength: 500),
                        Seokeywords = c.String(maxLength: 250),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Menu_ID = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                        Categories_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Categories", t => t.Categories_Id)
                .Index(t => t.Categories_Id);
            
            CreateTable(
                "dbo.tb_Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Menu_ID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                        Categories_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Categories", t => t.Categories_Id)
                .Index(t => t.Categories_Id);
            
            CreateTable(
                "dbo.tb_Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Email = c.String(maxLength: 150),
                        Website = c.String(),
                        Message = c.String(maxLength: 4000),
                        IsRead = c.Boolean(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        CustomerName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.tb_Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.tb_Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCate_ID = c.Int(nullable: false),
                        ProductName = c.String(),
                        ProductCode = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceSale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsHome = c.Boolean(nullable: false),
                        IsSale = c.Boolean(nullable: false),
                        IsFeature = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_ProductCategorys", t => t.ProductCategory_Id)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.tb_ProductCategorys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tb_Subcribed",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_SystemSettings",
                c => new
                    {
                        SettingKey = c.String(nullable: false, maxLength: 50),
                        SettingValue = c.String(maxLength: 4000),
                        SettingDescription = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.SettingKey);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        Phone = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.tb_OrderDetails", "ProductID", "dbo.tb_Products");
            DropForeignKey("dbo.tb_Products", "ProductCategory_Id", "dbo.tb_ProductCategorys");
            DropForeignKey("dbo.tb_OrderDetails", "OrderId", "dbo.tb_Orders");
            DropForeignKey("dbo.tb_Posts", "Categories_Id", "dbo.tb_Categories");
            DropForeignKey("dbo.tb_News", "Categories_Id", "dbo.tb_Categories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.tb_Products", new[] { "ProductCategory_Id" });
            DropIndex("dbo.tb_OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.tb_OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.tb_Posts", new[] { "Categories_Id" });
            DropIndex("dbo.tb_News", new[] { "Categories_Id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.tb_SystemSettings");
            DropTable("dbo.tb_Subcribed");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.tb_ProductCategorys");
            DropTable("dbo.tb_Products");
            DropTable("dbo.tb_OrderDetails");
            DropTable("dbo.tb_Orders");
            DropTable("dbo.tb_Contacts");
            DropTable("dbo.tb_Posts");
            DropTable("dbo.tb_News");
            DropTable("dbo.tb_Categories");
            DropTable("dbo.tb_Advs");
        }
    }
}
