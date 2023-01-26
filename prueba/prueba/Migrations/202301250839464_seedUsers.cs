namespace prueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'13ec6c2f-95cf-4bea-b640-a7d3d39fdf28', N'admin@vidly.com', 0, N'AOLXMa2RS7kpqlFntqXNxFr/SPFduh7m+L5RgCVVKxu92vRJAs11853/KVZVlBqArA==', N'90aa2f56-6186-4356-924c-3503bf1cad12', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'70966db0-bc0e-4c91-bcf4-bc5f7f7af8c5', N'guest@vidly.com', 0, N'ADRYIg6Wf4HAE9UuOHZrXYJdnpHU+WxZhPAKBJt9/mYKLU8ZQg+0x1ySw1vKtXJeFA==', N'304e345d-d0e2-48c6-8061-dcaa6eb12fde', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c9b0b2a1-0b9b-4b9f-9b9a-8b9b4b9f9b9a', N'CanManageMovies')


                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'13ec6c2f-95cf-4bea-b640-a7d3d39fdf28', N'c9b0b2a1-0b9b-4b9f-9b9a-8b9b4b9f9b9a')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
