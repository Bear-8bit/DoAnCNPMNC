namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Orders", "OrderStatus_Id", "dbo.tb_OrderStatus");
            DropIndex("dbo.tb_Orders", new[] { "OrderStatus_Id" });
            AddColumn("dbo.tb_Orders", "OrderStatus_Id1", c => c.Int());
            AlterColumn("dbo.tb_Orders", "OrderStatus_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Orders", "OrderStatus_Id1");
            AddForeignKey("dbo.tb_Orders", "OrderStatus_Id1", "dbo.tb_OrderStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Orders", "OrderStatus_Id1", "dbo.tb_OrderStatus");
            DropIndex("dbo.tb_Orders", new[] { "OrderStatus_Id1" });
            AlterColumn("dbo.tb_Orders", "OrderStatus_Id", c => c.Int());
            DropColumn("dbo.tb_Orders", "OrderStatus_Id1");
            CreateIndex("dbo.tb_Orders", "OrderStatus_Id");
            AddForeignKey("dbo.tb_Orders", "OrderStatus_Id", "dbo.tb_OrderStatus", "Id");
        }
    }
}
