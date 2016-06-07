namespace CreditBoard.DTO
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDBMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pkProfileId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                        IsEnabled = c.String(nullable: false),
                        IsDeleted = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pkUserId = c.Int(nullable: false),
                        fkProfileId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        PasswordHash = c.String(),
                        Email = c.String(nullable: false, maxLength: 80),
                        Language = c.String(nullable: false, maxLength: 50),
                        IsEnabled = c.String(nullable: false),
                        IsDeleted = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.fkProfileId)
                .Index(t => t.fkProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "fkProfileId", "dbo.Profile");
            DropIndex("dbo.User", new[] { "fkProfileId" });
            DropTable("dbo.User");
            DropTable("dbo.Profile");
        }
    }
}
