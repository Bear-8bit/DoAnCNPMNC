namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestReview : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_UserReview", "User_Id", "dbo.tb_Usexr");
            DropIndex("dbo.tb_UserReview", new[] { "User_Id" });
            DropColumn("dbo.tb_UserReview", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_UserReview", "User_Id", c => c.Int());
            CreateIndex("dbo.tb_UserReview", "User_Id");
            AddForeignKey("dbo.tb_UserReview", "User_Id", "dbo.tb_Usexr", "Id");
        }
    }
}
