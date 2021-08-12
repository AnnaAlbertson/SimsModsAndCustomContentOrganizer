namespace SMACCO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomContent",
                c => new
                    {
                        CustomContentID = c.Int(nullable: false),
                        IsBuyMode = c.Boolean(nullable: false),
                        IsCreateASim = c.Boolean(nullable: false),
                        Category = c.String(),
                        Subcategory = c.String(),
                    })
                .PrimaryKey(t => t.CustomContentID)
                .ForeignKey("dbo.Download", t => t.CustomContentID)
                .Index(t => t.CustomContentID);
            
            CreateTable(
                "dbo.Download",
                c => new
                    {
                        DownloadID = c.Int(nullable: false, identity: true),
                        DownloadName = c.String(nullable: false),
                        CreatorName = c.String(),
                        DownloadURL = c.String(),
                        LastDownloaded = c.DateTime(nullable: false),
                        IsMod = c.Boolean(nullable: false),
                        IsCustomContent = c.Boolean(nullable: false),
                        GameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DownloadID)
                .ForeignKey("dbo.Game", t => t.GameID, cascadeDelete: true)
                .Index(t => t.GameID);
            
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        GameName = c.String(nullable: false),
                        IsOwned = c.Boolean(nullable: false),
                        LastPatchUpdate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.GameID);
            
            CreateTable(
                "dbo.Mod",
                c => new
                    {
                        ModID = c.Int(nullable: false),
                        Category = c.String(maxLength: 50),
                        Description = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ModID)
                .ForeignKey("dbo.Download", t => t.ModID)
                .Index(t => t.ModID);
            
            CreateTable(
                "dbo.Pack",
                c => new
                    {
                        PackID = c.Int(nullable: false, identity: true),
                        PackName = c.String(nullable: false),
                        Description = c.String(),
                        IsOwned = c.Boolean(nullable: false),
                        GameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PackID)
                .ForeignKey("dbo.Game", t => t.GameID, cascadeDelete: true)
                .Index(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pack", "GameID", "dbo.Game");
            DropForeignKey("dbo.CustomContent", "CustomContentID", "dbo.Download");
            DropForeignKey("dbo.Mod", "ModID", "dbo.Download");
            DropForeignKey("dbo.Download", "GameID", "dbo.Game");
            DropIndex("dbo.Pack", new[] { "GameID" });
            DropIndex("dbo.Mod", new[] { "ModID" });
            DropIndex("dbo.Download", new[] { "GameID" });
            DropIndex("dbo.CustomContent", new[] { "CustomContentID" });
            DropTable("dbo.Pack");
            DropTable("dbo.Mod");
            DropTable("dbo.Game");
            DropTable("dbo.Download");
            DropTable("dbo.CustomContent");
        }
    }
}
