namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_UserReview", "Code", c => c.String());
            AddColumn("dbo.tb_UserReview", "Is1Star", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_UserReview", "Is2Star", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_UserReview", "Is3Star", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_UserReview", "Is4Star", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_UserReview", "Is5Star", c => c.Boolean(nullable: false));
            DropColumn("dbo.tb_UserReview", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_UserReview", "Rating", c => c.Int(nullable: false));
            DropColumn("dbo.tb_UserReview", "Is5Star");
            DropColumn("dbo.tb_UserReview", "Is4Star");
            DropColumn("dbo.tb_UserReview", "Is3Star");
            DropColumn("dbo.tb_UserReview", "Is2Star");
            DropColumn("dbo.tb_UserReview", "Is1Star");
            DropColumn("dbo.tb_UserReview", "Code");
        }
    }
}
