namespace DanceHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Types (Id, Name) VALUES(1,'Party')");
            Sql("INSERT INTO Types (Id, Name) VALUES(2,'Group Class')");
            Sql("INSERT INTO Types (Id, Name) VALUES(3,'Classic')");
            Sql("INSERT INTO Types (Id, Name) VALUES(4,'Showcase')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Types WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
