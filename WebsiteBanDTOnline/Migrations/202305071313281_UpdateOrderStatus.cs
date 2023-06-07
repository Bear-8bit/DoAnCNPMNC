namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_OrderStatus", "Name", c => c.String());
            DropColumn("dbo.tb_OrderStatus", "OrderId");
            DropColumn("dbo.tb_OrderStatus", "OrderStatusId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_OrderStatus", "OrderStatusId", c => c.Int(nullable: false));
            AddColumn("dbo.tb_OrderStatus", "OrderId", c => c.Int(nullable: false));
            DropColumn("dbo.tb_OrderStatus", "Name");
        }
    }
}
