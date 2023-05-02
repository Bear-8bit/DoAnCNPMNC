namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Survey", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Survey", "Comment");
        }
    }
}
