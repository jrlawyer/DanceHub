namespace DanceHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDanceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Location = c.String(),
                        Studio_Id = c.String(maxLength: 128),
                        Type_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Studio_Id)
                .ForeignKey("dbo.Types", t => t.Type_Id)
                .Index(t => t.Studio_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Events", "Studio_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "Type_Id" });
            DropIndex("dbo.Events", new[] { "Studio_Id" });
            DropTable("dbo.Types");
            DropTable("dbo.Events");
        }
    }
}
