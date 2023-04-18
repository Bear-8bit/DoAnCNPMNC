namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Orders", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Orders", "Email");
        }
    }
}
