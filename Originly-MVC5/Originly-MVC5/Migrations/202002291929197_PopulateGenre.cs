namespace Originly_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (1,'Platform')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2,'Shooter')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3,'BattleRoyale')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4,'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (5,'Role-Playing')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (6,'Simulation')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (7,'Strategy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (8,'Sports')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (9,'Other')");
        }
        
        public override void Down()
        {
        }
    }
}
