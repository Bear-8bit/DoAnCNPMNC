namespace WebsiteBanDTOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Usexr",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirsName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_Usexr");
        }
    }
}
