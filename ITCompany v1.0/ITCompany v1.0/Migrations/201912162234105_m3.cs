namespace ITCompany_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProjectTasksModels", "TasksModel_Id", "dbo.TasksModels");
            DropForeignKey("dbo.TasksModels", "ProjectTasksModel_Id", "dbo.ProjectTasksModels");
            DropForeignKey("dbo.ProjectTasksModels", "Tasks_Id", "dbo.TasksModels");
            DropIndex("dbo.ProjectTasksModels", new[] { "TasksModel_Id" });
            DropIndex("dbo.ProjectTasksModels", new[] { "Tasks_Id" });
            DropIndex("dbo.TasksModels", new[] { "ProjectTasksModel_Id" });
            RenameColumn(table: "dbo.ProjectTasksModels", name: "Projects_Id", newName: "ProjectsModel_Id");
            RenameIndex(table: "dbo.ProjectTasksModels", name: "IX_Projects_Id", newName: "IX_ProjectsModel_Id");
            AddColumn("dbo.ProjectTasksModels", "Project_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ProjectTasksModels", "TasksModel_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ProjectTasksModels", "Tasks_Id", c => c.Int(nullable: false));
            DropTable("dbo.TasksModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TasksModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Task = c.String(),
                        Description = c.String(),
                        Deadline_Time = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        ProjectTasksModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.ProjectTasksModels", "Tasks_Id", c => c.Int());
            AlterColumn("dbo.ProjectTasksModels", "TasksModel_Id", c => c.Int());
            DropColumn("dbo.ProjectManagerModels", "Name_PM");
            DropColumn("dbo.ProjectTasksModels", "Project_Id");
            RenameIndex(table: "dbo.ProjectTasksModels", name: "IX_ProjectsModel_Id", newName: "IX_Projects_Id");
            RenameColumn(table: "dbo.ProjectTasksModels", name: "ProjectsModel_Id", newName: "Projects_Id");
            CreateIndex("dbo.TasksModels", "ProjectTasksModel_Id");
            CreateIndex("dbo.ProjectTasksModels", "Tasks_Id");
            CreateIndex("dbo.ProjectTasksModels", "TasksModel_Id");
            AddForeignKey("dbo.ProjectTasksModels", "Tasks_Id", "dbo.TasksModels", "Id");
            AddForeignKey("dbo.TasksModels", "ProjectTasksModel_Id", "dbo.ProjectTasksModels", "Id");
            AddForeignKey("dbo.ProjectTasksModels", "TasksModel_Id", "dbo.TasksModels", "Id");
        }
    }
}
