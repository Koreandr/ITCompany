using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITCompany_v1._0.Model;
using ITCompany_v1._0.Models;


namespace ITCompany_v1._0.DBConnect
{
  ///<summary> This class is used to connect to DataBase and Initialize it in our program 
        ///<para> Reads connection info with name "DBConnection" that is listed in App.config </para>
        /// <seealso cref="App.config"/>
        /// </summary>  
 public class MainDataBase : DbContext
    {
        public MainDataBase() : base("DBConnection")
        {
        }
        static MainDataBase()
        {
            Database.SetInitializer(new DBInitializer());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProjectTasksModel>()
        //        .HasMany(x => x.Project_Id)
        //        .WillCascadeOnDelete(false);
        //}

        public DbSet<DepartamentsModel> Departaments { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProjectsModel> Projects { get; set; }
        public DbSet<ProjectManagerModel> ProjectManagers { get; set; }
        //public object ProjectsModel { get; internal set; }
    }

}
