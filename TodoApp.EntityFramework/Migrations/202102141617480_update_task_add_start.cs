namespace TodoApp.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_task_add_start : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Start", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Start");
        }
    }
}
