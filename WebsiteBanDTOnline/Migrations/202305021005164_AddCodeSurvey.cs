namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCodeSurvey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Survey", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Survey", "Code");
        }
    }
}
