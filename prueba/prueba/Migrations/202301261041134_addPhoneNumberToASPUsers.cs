namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhoneNumberToASPUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Customers", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}
