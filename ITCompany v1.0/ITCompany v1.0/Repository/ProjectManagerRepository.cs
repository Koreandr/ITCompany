using ITCompany_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;
using ITCompany_v1._0.DBConnect;

namespace ITCompany_v1._0.Repository
{
    public class ProjectManagerRepository : GeneralRepository<ProjectManagerModel>
    {
        public ProjectManagerRepository(MainDataBase database) : base(database)
        {
        }

        public override void Add(ProjectManagerModel entity)
        {

            _database.ProjectManagers.Add(entity);
            _database.SaveChanges();

        }
        public override void Delete(ProjectManagerModel entity)
        {
            _database.Entry(entity).State = EntityState.Deleted;
            _database.SaveChanges();
        }

        public override void Edit(ProjectManagerModel entity)
        {
            _database.Entry(entity).State = EntityState.Modified;
            _database.SaveChanges();
        }

        public override ProjectManagerModel GetById(int id)
        {
            return _database.ProjectManagers.Find(id);
        }

        public override List<ProjectManagerModel> GetAll()
        {
            return _database.ProjectManagers.ToList();
        }

        public override void Save()
        {
            _database.SaveChanges();
        }

        public override List<ProjectManagerModel> GetAll(Expression<Func<ProjectManagerModel, bool>> predicate)
        {
            return _database.ProjectManagers.Where(predicate).ToList();
        }
    }
}
