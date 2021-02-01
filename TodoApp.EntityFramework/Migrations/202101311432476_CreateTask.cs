namespace TodoApp.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Priority = c.Int(nullable: false),
                        Start = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaskTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tag_Id = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tags", t => t.Tag_Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Tag_Id)
                .Index(t => t.Task_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskTags", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.TaskTags", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.TaskTags", new[] { "Task_Id" });
            DropIndex("dbo.TaskTags", new[] { "Tag_Id" });
            DropTable("dbo.TaskTags");
            DropTable("dbo.Tasks");
            DropTable("dbo.Tags");
        }
    }
}
