namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_User", "FirsName", c => c.String());
            AddColumn("dbo.tb_User", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_User", "LastName");
            DropColumn("dbo.tb_User", "FirsName");
        }
    }
}
