namespace SMACCO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGuidOwnerID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomContent", "OwnerID", c => c.Guid(nullable: false));
            AddColumn("dbo.Download", "OwnerID", c => c.Guid(nullable: false));
            AddColumn("dbo.Game", "OwnerID", c => c.Guid(nullable: false));
            AddColumn("dbo.Mod", "OwnerID", c => c.Guid(nullable: false));
            AddColumn("dbo.Pack", "OwnerID", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pack", "OwnerID");
            DropColumn("dbo.Mod", "OwnerID");
            DropColumn("dbo.Game", "OwnerID");
            DropColumn("dbo.Download", "OwnerID");
            DropColumn("dbo.CustomContent", "OwnerID");
        }
    }
}
