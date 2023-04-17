﻿namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Products", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Products", "PriceSale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
