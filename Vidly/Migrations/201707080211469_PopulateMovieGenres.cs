namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MovieGenres (Id, GenreName) values (1,'Action')");
            Sql("Insert into MovieGenres (Id, GenreName) values (2,'Comedy')");
            Sql("Insert into MovieGenres (Id, GenreName) values (3,'Family')");
            Sql("Insert into MovieGenres (Id, GenreName) values (4,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
