namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_UserReview",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Rating = c.Int(nullable: false),
                        Comment = c.String(maxLength: 750),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_UserReview");
        }
    }
}
