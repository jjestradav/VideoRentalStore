namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'362d7e0c-1b5a-4ecd-b9b8-435185bd1a94', N'admin@vidly.com', 0, N'AOs//EWT4kTnEAEa/cUQQQHmRhVD3WzDxtvLTpSIiLQX33MRyy1wIbF6WAnGY1WZcg==', N'9044ed8d-8046-441f-a486-9c7c3446a4b4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'39ed44a8-dc7a-437d-a7aa-ca7f41210517', N'guest@vidly.com', 0, N'ANDMGHwToHrbdE+EGcwvyZFkxP+qtKFaKFMrEx8H4CcEf7k4vtIQysdOZnQB0Kgv7A==', N'413867e1-c1d9-4e59-89ce-df4111b44247', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fa3ad872-7ee2-4bb4-9366-780adcb46c09', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'362d7e0c-1b5a-4ecd-b9b8-435185bd1a94', N'fa3ad872-7ee2-4bb4-9366-780adcb46c09')  ");

        }
        
        public override void Down()
        {
        }
    }
}
