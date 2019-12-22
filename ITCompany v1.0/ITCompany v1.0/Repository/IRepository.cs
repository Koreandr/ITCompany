﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
