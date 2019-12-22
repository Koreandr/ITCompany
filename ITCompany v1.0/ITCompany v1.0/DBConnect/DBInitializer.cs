using ITCompany_v1._0.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ITCompany_v1._0.DBConnect
{
    class DBInitializer : CreateDatabaseIfNotExists<MainDataBase>
    {
        UsersRepository _usersRepository;
        ProjectsRepository _projectsRepository;
        ProjectManagerRepository _projectManagerRepository;


        protected override void Seed(MainDataBase dataBase)
        {
            _usersRepository = new UsersRepository(dataBase);
            _projectsRepository = new ProjectsRepository(dataBase);
            _projectManagerRepository = new ProjectManagerRepository(dataBase);

        }
    }
}
