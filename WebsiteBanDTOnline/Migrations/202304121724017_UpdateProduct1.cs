namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProduct1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_ProductImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.tb_Products", "SeoTitle", c => c.String());
            AddColumn("dbo.tb_Products", "SeoDescription", c => c.String());
            AddColumn("dbo.tb_Products", "SeoKeywords", c => c.String());
            AddColumn("dbo.tb_Products", "CreatedBy", c => c.String());
            AddColumn("dbo.tb_Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.tb_Products", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.tb_Products", "ModifiedDate", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ProductImages", "ProductId", "dbo.tb_Products");
            DropIndex("dbo.tb_ProductImages", new[] { "ProductId" });
            DropColumn("dbo.tb_Products", "ModifiedDate");
            DropColumn("dbo.tb_Products", "CreatedTime");
            DropColumn("dbo.tb_Products", "CreatedDate");
            DropColumn("dbo.tb_Products", "CreatedBy");
            DropColumn("dbo.tb_Products", "SeoKeywords");
            DropColumn("dbo.tb_Products", "SeoDescription");
            DropColumn("dbo.tb_Products", "SeoTitle");
            DropTable("dbo.tb_ProductImages");
        }
    }
}
