namespace TodoApp.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "Priority");
            DropColumn("dbo.Tasks", "Start");
            DropColumn("dbo.Tasks", "IsFinished");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "IsFinished", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tasks", "Start", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "Priority", c => c.Int(nullable: false));
        }
    }
}
