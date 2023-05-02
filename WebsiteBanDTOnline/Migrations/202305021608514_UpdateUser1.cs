namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Usexr", "CreatedBy", c => c.String());
            AddColumn("dbo.tb_Usexr", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.tb_Usexr", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.tb_Usexr", "ModifiedDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Usexr", "ModifiedDate");
            DropColumn("dbo.tb_Usexr", "CreatedTime");
            DropColumn("dbo.tb_Usexr", "CreatedDate");
            DropColumn("dbo.tb_Usexr", "CreatedBy");
        }
    }
}
