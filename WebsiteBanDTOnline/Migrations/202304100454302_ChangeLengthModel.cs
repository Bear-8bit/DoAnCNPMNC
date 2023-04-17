namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLengthModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Products", "Alias", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Products", "ProductName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.tb_Products", "ProductCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.tb_Products", "Image", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Products", "Image", c => c.String());
            AlterColumn("dbo.tb_Products", "ProductCode", c => c.String());
            AlterColumn("dbo.tb_Products", "ProductName", c => c.String());
            AlterColumn("dbo.tb_Products", "Alias", c => c.String());
        }
    }
}
