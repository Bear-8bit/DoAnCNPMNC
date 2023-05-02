namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableSurvey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Survey",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        IsRecommended = c.Boolean(nullable: false),
                        IsNotRecommended = c.Boolean(nullable: false),
                        Is1Star = c.Boolean(nullable: false),
                        Is2Star = c.Boolean(nullable: false),
                        Is3Star = c.Boolean(nullable: false),
                        Is4Star = c.Boolean(nullable: false),
                        Is5Star = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Usexr", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Survey", "Id", "dbo.tb_Usexr");
            DropIndex("dbo.tb_Survey", new[] { "Id" });
            DropTable("dbo.tb_Survey");
        }
    }
}
