using ITCompany_v1._0.DBConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Repository
{
    public abstract class GeneralRepository<T> : IRepository<T> where T : class
    {
        protected MainDataBase _database;

        public GeneralRepository(MainDataBase dataBase)
        {
            _database = dataBase;
        }

        public abstract T GetById(int id);
        public abstract List<T> GetAll();
        public abstract List<T> GetAll(Expression<Func<T, bool>> predicate);
        public abstract void Add(T entity);
        public abstract void Delete(T entity);
        public abstract void Edit(T entity);
        public abstract void Save();
    }


}

