namespace TimmApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedDuplicate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Fname = c.String(nullable: false),
                        Lname = c.String(nullable: false),
                        PhoneNum = c.Int(nullable: false),
                        Email = c.String(),
                        Role = c.String(nullable: false),
                        EmployedAs = c.Int(nullable: false),
                        ContractStartDate = c.DateTime(nullable: false),
                        ContractEndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        postId = c.Int(nullable: false, identity: true),
                        postMsg = c.String(nullable: false, maxLength: 255),
                        priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.postId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
            DropTable("dbo.Employees");
        }
    }
}
