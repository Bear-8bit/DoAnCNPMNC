namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSurvey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Survey", "CreatedBy", c => c.String());
            AddColumn("dbo.tb_Survey", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.tb_Survey", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.tb_Survey", "ModifiedDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Survey", "ModifiedDate");
            DropColumn("dbo.tb_Survey", "CreatedTime");
            DropColumn("dbo.tb_Survey", "CreatedDate");
            DropColumn("dbo.tb_Survey", "CreatedBy");
        }
    }
}
