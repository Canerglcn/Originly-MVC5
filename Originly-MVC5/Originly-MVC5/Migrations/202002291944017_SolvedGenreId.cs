namespace Originly_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SolvedGenreId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropColumn("dbo.Games", "GenreId");
            RenameColumn(table: "dbo.Games", name: "Genre_Id", newName: "GenreId");
            AlterColumn("dbo.Games", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Games", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Games", "GenreId");
            AddForeignKey("dbo.Games", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "GenreId" });
            AlterColumn("dbo.Games", "GenreId", c => c.Byte());
            AlterColumn("dbo.Games", "GenreId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Games", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbo.Games", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "Genre_Id");
            AddForeignKey("dbo.Games", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
