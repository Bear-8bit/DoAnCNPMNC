namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserProductRElation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Products", "User_Id", "dbo.tb_Usexr");
            DropIndex("dbo.tb_Products", new[] { "User_Id" });
            DropColumn("dbo.tb_Products", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Products", "User_Id", c => c.Int());
            CreateIndex("dbo.tb_Products", "User_Id");
            AddForeignKey("dbo.tb_Products", "User_Id", "dbo.tb_Usexr", "Id");
        }
    }
}
