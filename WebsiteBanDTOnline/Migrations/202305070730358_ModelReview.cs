namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Products", "User_Id", c => c.Int());
            AddColumn("dbo.tb_UserReview", "Product_Id1", c => c.Int());
            AddColumn("dbo.tb_UserReview", "User_Id", c => c.Int());
            CreateIndex("dbo.tb_Products", "User_Id");
            CreateIndex("dbo.tb_UserReview", "Product_Id1");
            CreateIndex("dbo.tb_UserReview", "User_Id");
            AddForeignKey("dbo.tb_UserReview", "Product_Id1", "dbo.tb_Products", "Id");
            AddForeignKey("dbo.tb_Products", "User_Id", "dbo.tb_Usexr", "Id");
            AddForeignKey("dbo.tb_UserReview", "User_Id", "dbo.tb_Usexr", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_UserReview", "User_Id", "dbo.tb_Usexr");
            DropForeignKey("dbo.tb_Products", "User_Id", "dbo.tb_Usexr");
            DropForeignKey("dbo.tb_UserReview", "Product_Id1", "dbo.tb_Products");
            DropIndex("dbo.tb_UserReview", new[] { "User_Id" });
            DropIndex("dbo.tb_UserReview", new[] { "Product_Id1" });
            DropIndex("dbo.tb_Products", new[] { "User_Id" });
            DropColumn("dbo.tb_UserReview", "User_Id");
            DropColumn("dbo.tb_UserReview", "Product_Id1");
            DropColumn("dbo.tb_Products", "User_Id");
        }
    }
}
