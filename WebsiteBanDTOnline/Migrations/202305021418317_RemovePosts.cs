namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePosts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Posts", "Categories_Id", "dbo.tb_Categories");
            DropIndex("dbo.tb_Posts", new[] { "Categories_Id" });
            DropTable("dbo.tb_Posts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tb_Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Menu_ID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        ModifiedDate = c.String(),
                        Categories_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.tb_Posts", "Categories_Id");
            AddForeignKey("dbo.tb_Posts", "Categories_Id", "dbo.tb_Categories", "Id");
        }
    }
}
