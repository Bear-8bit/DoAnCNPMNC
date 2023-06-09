﻿namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Categories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_News", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Posts", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Products", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Products", "IsActive");
            DropColumn("dbo.tb_Posts", "IsActive");
            DropColumn("dbo.tb_News", "IsActive");
            DropColumn("dbo.tb_Categories", "IsActive");
        }
    }
}
