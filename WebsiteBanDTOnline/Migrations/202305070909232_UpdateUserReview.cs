namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserReview : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.tb_UserReview", new[] { "Product_Id1" });
            DropColumn("dbo.tb_UserReview", "Product_Id");
            RenameColumn(table: "dbo.tb_UserReview", name: "Product_Id1", newName: "Product_Id");
            AlterColumn("dbo.tb_UserReview", "Product_Id", c => c.Int());
            CreateIndex("dbo.tb_UserReview", "Product_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.tb_UserReview", new[] { "Product_Id" });
            AlterColumn("dbo.tb_UserReview", "Product_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tb_UserReview", name: "Product_Id", newName: "Product_Id1");
            AddColumn("dbo.tb_UserReview", "Product_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_UserReview", "Product_Id1");
        }
    }
}
