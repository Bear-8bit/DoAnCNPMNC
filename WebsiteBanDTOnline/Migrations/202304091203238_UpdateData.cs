namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Categories", "Alias", c => c.String());
            AddColumn("dbo.tb_News", "Alias", c => c.String());
            AddColumn("dbo.tb_Posts", "Alias", c => c.String());
            AddColumn("dbo.tb_Products", "Alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Products", "Alias");
            DropColumn("dbo.tb_Posts", "Alias");
            DropColumn("dbo.tb_News", "Alias");
            DropColumn("dbo.tb_Categories", "Alias");
        }
    }
}
