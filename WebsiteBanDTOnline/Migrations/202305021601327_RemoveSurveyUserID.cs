namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSurveyUserID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Usexr", "Survey_Id", "dbo.tb_Survey");
            DropIndex("dbo.tb_Usexr", new[] { "Survey_Id" });
            DropColumn("dbo.tb_Usexr", "Survey_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Usexr", "Survey_Id", c => c.Int());
            CreateIndex("dbo.tb_Usexr", "Survey_Id");
            AddForeignKey("dbo.tb_Usexr", "Survey_Id", "dbo.tb_Survey", "Id");
        }
    }
}
