namespace tutor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class About : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "About", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "About");
        }
    }
}
