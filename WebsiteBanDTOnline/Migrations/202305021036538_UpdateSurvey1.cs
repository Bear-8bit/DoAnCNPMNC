namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSurvey1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Survey", "User_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Survey", "User_Id");
        }
    }
}
