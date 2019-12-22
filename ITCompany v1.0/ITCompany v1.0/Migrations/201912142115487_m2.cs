namespace ITCompany_v1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProjectsModels", "Deadline_date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectsModels", "Deadline_date", c => c.DateTime(nullable: false));
        }
    }
}
