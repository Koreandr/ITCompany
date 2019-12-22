namespace ITCompany_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartamentsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Departament_Name = c.String(),
                        Number_Of_Employee = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Departament_Id = c.Int(),
                        Role = c.String(),
                        Admin = c.Boolean(nullable: false),
                        Hr = c.Boolean(nullable: false),
                        Pm = c.Boolean(nullable: false),
                        User = c.Boolean(nullable: false),
                        Departaments_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartamentsModels", t => t.Departaments_Id)
                .Index(t => t.Departaments_Id);
            
            CreateTable(
                "dbo.ProjectsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Project = c.String(),
                        Deadline_date = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectTasksModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Projects_Id = c.Int(),
                        Tasks_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectsModels", t => t.Projects_Id)
                .ForeignKey("dbo.TasksModels", t => t.Tasks_Id)
                .Index(t => t.Projects_Id)
                .Index(t => t.Tasks_Id);
            
            CreateTable(
                "dbo.ProjectManagerModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectTasksModel_Id = c.Int(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectTasksModels", t => t.ProjectTasksModel_Id)
                .ForeignKey("dbo.UserModels", t => t.Users_Id)
                .Index(t => t.ProjectTasksModel_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.TasksModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Task = c.String(),
                        Description = c.String(),
                        Deadline_Time = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTasksModels", "Tasks_Id", "dbo.TasksModels");
            DropForeignKey("dbo.ProjectTasksModels", "Projects_Id", "dbo.ProjectsModels");
            DropForeignKey("dbo.ProjectManagerModels", "Users_Id", "dbo.UserModels");
            DropForeignKey("dbo.ProjectManagerModels", "ProjectTasksModel_Id", "dbo.ProjectTasksModels");
            DropForeignKey("dbo.UserModels", "Departaments_Id", "dbo.DepartamentsModels");
            DropIndex("dbo.ProjectManagerModels", new[] { "Users_Id" });
            DropIndex("dbo.ProjectManagerModels", new[] { "ProjectTasksModel_Id" });
            DropIndex("dbo.ProjectTasksModels", new[] { "Tasks_Id" });
            DropIndex("dbo.ProjectTasksModels", new[] { "Projects_Id" });
            DropIndex("dbo.UserModels", new[] { "Departaments_Id" });
            DropTable("dbo.TasksModels");
            DropTable("dbo.ProjectManagerModels");
            DropTable("dbo.ProjectTasksModels");
            DropTable("dbo.ProjectsModels");
            DropTable("dbo.UserModels");
            DropTable("dbo.DepartamentsModels");
        }
    }
}
