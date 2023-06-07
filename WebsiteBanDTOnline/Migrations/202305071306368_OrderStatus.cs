namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tb_Orders", "OrderStatus_Id", c => c.Int());
            CreateIndex("dbo.tb_Orders", "OrderStatus_Id");
            AddForeignKey("dbo.tb_Orders", "OrderStatus_Id", "dbo.tb_OrderStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Orders", "OrderStatus_Id", "dbo.tb_OrderStatus");
            DropIndex("dbo.tb_Orders", new[] { "OrderStatus_Id" });
            DropColumn("dbo.tb_Orders", "OrderStatus_Id");
            DropTable("dbo.tb_OrderStatus");
        }
    }
}
