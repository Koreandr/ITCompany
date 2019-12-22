namespace ITCompany_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProjectTasksModels", "Tasks_Id", "dbo.TasksModels");
            AddColumn("dbo.ProjectTasksModels", "TasksModel_Id", c => c.Int());
            AddColumn("dbo.TasksModels", "ProjectTasksModel_Id", c => c.Int());
            CreateIndex("dbo.ProjectTasksModels", "TasksModel_Id");
            CreateIndex("dbo.TasksModels", "ProjectTasksModel_Id");
            AddForeignKey("dbo.TasksModels", "ProjectTasksModel_Id", "dbo.ProjectTasksModels", "Id");
            AddForeignKey("dbo.ProjectTasksModels", "TasksModel_Id", "dbo.TasksModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTasksModels", "TasksModel_Id", "dbo.TasksModels");
            DropForeignKey("dbo.TasksModels", "ProjectTasksModel_Id", "dbo.ProjectTasksModels");
            DropIndex("dbo.TasksModels", new[] { "ProjectTasksModel_Id" });
            DropIndex("dbo.ProjectTasksModels", new[] { "TasksModel_Id" });
            DropColumn("dbo.TasksModels", "ProjectTasksModel_Id");
            DropColumn("dbo.ProjectTasksModels", "TasksModel_Id");
            AddForeignKey("dbo.ProjectTasksModels", "Tasks_Id", "dbo.TasksModels", "Id");
        }
    }
}
