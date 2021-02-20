namespace TodoApp.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_status_field_to_task_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Status");
        }
    }
}
