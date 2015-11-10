namespace TimmApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "text");
        }
    }
}
