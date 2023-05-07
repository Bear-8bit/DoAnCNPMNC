namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_UserReview", "Product_Id", c => c.Int());
            CreateIndex("dbo.tb_UserReview", "Product_Id");
            AddForeignKey("dbo.tb_UserReview", "Product_Id", "dbo.tb_Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_UserReview", "Product_Id", "dbo.tb_Products");
            DropIndex("dbo.tb_UserReview", new[] { "Product_Id" });
            DropColumn("dbo.tb_UserReview", "Product_Id");
        }
    }
}
