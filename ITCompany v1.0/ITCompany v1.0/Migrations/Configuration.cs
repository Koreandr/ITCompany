namespace ITCompany_v1._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ITCompany_v1._0.DBConnect.MainDataBase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ITCompany_v1._0.DBConnect.MainDataBase";
        }

        protected override void Seed(ITCompany_v1._0.DBConnect.MainDataBase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
