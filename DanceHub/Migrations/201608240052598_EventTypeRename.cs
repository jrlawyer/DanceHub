namespace DanceHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTypeRename : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Types", newName: "EventTypes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EventTypes", newName: "Types");
        }
    }
}
