namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLengthProduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Products", "Detail", c => c.String(maxLength: 750));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Products", "Detail", c => c.String(maxLength: 500));
        }
    }
}
