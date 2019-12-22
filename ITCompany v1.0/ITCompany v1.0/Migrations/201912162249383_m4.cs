namespace ITCompany_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProjectTasksModels", "Project_Id", c => c.Int(nullable: true));
            AlterColumn("dbo.ProjectTasksModels", "Tasks_Id", c => c.Int(nullable: true));
            AlterColumn("dbo.ProjectTasksModels", "TasksModel_Id", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProjectTasksModels", "TasksModel_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ProjectTasksModels", "Tasks_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ProjectTasksModels", "Project_Id", c => c.Int(nullable: false));
        }
    }
}
