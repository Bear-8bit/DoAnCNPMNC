namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Products", "Detail", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Products", "Detail");
        }
    }
}
