namespace TimmApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        eventStart = c.DateTime(nullable: false),
                        eventEnd = c.DateTime(nullable: false),
                        employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.employee_EmployeeId)
                .Index(t => t.employee_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Events", new[] { "employee_EmployeeId" });
            DropTable("dbo.Events");
        }
    }
}
