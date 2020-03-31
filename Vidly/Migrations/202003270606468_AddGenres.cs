namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (NAME)  VALUES ('Comedy')");
            Sql("INSERT INTO GENRES (NAME)  VALUES ('Action')");
            Sql("INSERT INTO GENRES (NAME)  VALUES ('Romance')");
            Sql("INSERT INTO GENRES (NAME)  VALUES ('Family')");
        }

        
        public override void Down()
        {
        }
    }
}
