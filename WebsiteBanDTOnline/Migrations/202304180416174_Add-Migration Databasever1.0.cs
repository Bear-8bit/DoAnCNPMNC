namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationDatabasever10 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Orders", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Orders", "Email", c => c.String());
        }
    }
}
