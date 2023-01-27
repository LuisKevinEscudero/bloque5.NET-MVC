﻿namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}