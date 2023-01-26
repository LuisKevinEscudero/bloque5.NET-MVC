namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhoneNumberCoorect : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
