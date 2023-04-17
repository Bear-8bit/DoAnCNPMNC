namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategorys", "Alias", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategorys", "Alias");
        }
    }
}
