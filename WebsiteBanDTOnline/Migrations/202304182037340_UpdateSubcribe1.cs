namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSubcribe1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategorys", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategorys", "Image");
        }
    }
}
