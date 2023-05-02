namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSurvey2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Survey", "Id", "dbo.tb_Usexr");
            DropIndex("dbo.tb_Survey", new[] { "Id" });
            AddColumn("dbo.tb_Usexr", "Survey_Id", c => c.Int());
            CreateIndex("dbo.tb_Usexr", "Survey_Id");
            AddForeignKey("dbo.tb_Usexr", "Survey_Id", "dbo.tb_Survey", "Id");
            DropColumn("dbo.tb_Survey", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Survey", "User_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.tb_Usexr", "Survey_Id", "dbo.tb_Survey");
            DropIndex("dbo.tb_Usexr", new[] { "Survey_Id" });
            DropColumn("dbo.tb_Usexr", "Survey_Id");
            CreateIndex("dbo.tb_Survey", "Id");
            AddForeignKey("dbo.tb_Survey", "Id", "dbo.tb_Usexr", "Id");
        }
    }
}
