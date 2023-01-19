namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthdates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1980-01-01' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = '1990-01-01' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
