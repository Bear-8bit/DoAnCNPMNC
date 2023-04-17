namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTypePayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Orders", "TypePayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Orders", "TypePayment");
        }
    }
}
