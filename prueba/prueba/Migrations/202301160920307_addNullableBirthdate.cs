namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNullableBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
