namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        ReleaseDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        PublishingHauseId = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        SpecialOccasion = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.PublishingHauses", t => t.PublishingHauseId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.PublishingHauseId);
            
            CreateTable(
                "dbo.PublishingHauses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Editions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Release = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "PublishingHauseId", "dbo.PublishingHauses");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "PublishingHauseId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Editions");
            DropTable("dbo.Covers");
            DropTable("dbo.Carriers");
            DropTable("dbo.PublishingHauses");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
