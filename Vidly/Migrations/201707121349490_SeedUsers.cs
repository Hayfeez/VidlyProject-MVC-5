namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'acbc5600-a655-4f0c-9a87-4dddb1c360c8', N'admin@vidly.com', 0, N'AG+VhTDovKnMrxxlRx+9V6CkihlOzVpZ2euGFFv/tKPnSRfkLkj7hxAZefKwM117XQ==', N'24852757-9b90-4b5f-ab05-b1d8b4cd4ce1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd6fbf1d-4f48-4dea-9d9d-6ac4787d1f86', N'guest@vidly.com', 0, N'AK0ock9vgyS5Tp7pHaGsBza9oIoS7uMyIr/VYB5gYU0A+Kozg5n4i2WrfMNBKUy6xQ==', N'69b15eb6-2610-4c65-ad74-6a7b06753495', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8add5dad-2d25-40fb-8f5f-3f8d9d8f83db', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'acbc5600-a655-4f0c-9a87-4dddb1c360c8', N'8add5dad-2d25-40fb-8f5f-3f8d9d8f83db')

");
        }
        
        public override void Down()
        {
        }
    }
}
