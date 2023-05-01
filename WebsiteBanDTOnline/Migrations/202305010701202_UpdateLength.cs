namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Products", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Products", "Detail", c => c.String(maxLength: 2000));
        }
    }
}
