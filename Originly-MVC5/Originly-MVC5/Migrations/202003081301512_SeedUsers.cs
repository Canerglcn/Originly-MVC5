namespace Originly_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b3bdfda7-c9f1-46ba-94a8-56b2cf8caec5', N'admin@originly.com', 0, N'AHsLC5xm2Us94r6Cd3oBEHBtemxjaMA6HyYmyrtwTnD+L7nRoOhF8eMzBmkjwXiAPw==', N'e84bbd55-b9a6-4d6f-843e-29ac9cb32129', NULL, 0, 0, NULL, 1, 0, N'admin@originly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b4f20397-a961-4214-81db-8cf7f129c96f', N'guest@originly.com', 0, N'APL2Vq6+TjaOCsJlxdRQ9R+D4YQHRDps/rmA18zQyvlJ89nFhlIgeLM5ZC8wY4Xr+w==', N'18b99724-3cc3-41b6-8598-0309b7aad98b', NULL, 0, 0, NULL, 1, 0, N'guest@originly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6bd4727e-7c8f-48bf-83a8-571ef2d809fb', N'CanManageGames')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b3bdfda7-c9f1-46ba-94a8-56b2cf8caec5', N'6bd4727e-7c8f-48bf-83a8-571ef2d809fb')

");
        }
        
        public override void Down()
        {
        }
    }
}
