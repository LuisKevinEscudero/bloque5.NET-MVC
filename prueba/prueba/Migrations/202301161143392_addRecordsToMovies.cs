namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRecordsToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, Genre_Id) VALUES ('Hangover', 5, 1)");
            Sql("INSERT INTO Movies (Name, GenreId, Genre_Id) VALUES ('Die Hard', 1, 1)");
            Sql("INSERT INTO Movies (Name, GenreId, Genre_Id) VALUES ('The Terminator', 1, 1)");
            Sql("INSERT INTO Movies (Name, GenreId, Genre_Id) VALUES ('Toy Story', 3, 1)");
            Sql("INSERT INTO Movies (Name, GenreId, Genre_Id) VALUES ('Titanic', 4, 1)");
        }

        public override void Down()
        {
        }
    }
}
