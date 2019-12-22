using ITCompany_v1._0.DBConnect;
using ITCompany_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;


namespace ITCompany_v1._0.Repository
{
    public class ProjectsRepository : GeneralRepository<ProjectsModel>
    {
        public ProjectsRepository(MainDataBase database) : base(database)
        {
        }

        public override void Add(ProjectsModel entity)
        {
           
            _database.Projects.Add(entity);
            _database.SaveChanges();

        }

        public override void Delete(ProjectsModel entity)
        {
            _database.Entry(entity).State = EntityState.Deleted;
            _database.SaveChanges();
        }

        public override void Edit(ProjectsModel entity)
        {
            _database.Entry(entity).State = EntityState.Modified;
            _database.SaveChanges();
        }

        public override ProjectsModel GetById(int id)
        {
            return _database.Projects.Find(id);
        }

        public override List<ProjectsModel> GetAll()
        {
            return _database.Projects.ToList();
        }
       
        public override void Save()
        {
            _database.SaveChanges();
        }

        public override List<ProjectsModel> GetAll(Expression<Func<ProjectsModel, bool>> predicate)
        {
            return _database.Projects.Where(predicate).ToList();
        }
       
    }
}
