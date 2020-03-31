namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneNumberAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone_Number", c => c.String(nullable: false, maxLength: 50));
         
        }
        
        public override void Down()
        {
           
            DropColumn("dbo.AspNetUsers", "Phone_Number");
        }
    }
}
