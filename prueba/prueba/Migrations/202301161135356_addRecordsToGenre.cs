namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRecordsToGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name, DateAdded, ReleaseDate,NumberInStock) VALUES ('Comedy' , '2018-01-01', '2018-01-01', 5)");
            Sql("INSERT INTO Genres ( Name, DateAdded, ReleaseDate,NumberInStock) VALUES ('Action' , '2018-01-01', '2018-01-01', 5)");
            Sql("INSERT INTO Genres (Name, DateAdded, ReleaseDate,NumberInStock) VALUES ('Family' , '2018-01-01', '2018-01-01', 5)");
            Sql("INSERT INTO Genres (Name, DateAdded, ReleaseDate,NumberInStock) VALUES ('Romance' , '2018-01-01', '2018-01-01', 5)");
        }

        public override void Down()
        {
        }
    }
}
