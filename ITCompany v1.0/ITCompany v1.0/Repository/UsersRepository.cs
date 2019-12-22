
using ITCompany_v1._0.DBConnect;
using ITCompany_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ITCompany_v1._0.Repository
{
  public  class UsersRepository : GeneralRepository<UserModel>
    {
        public UsersRepository(MainDataBase database) : base(database) { }

        public override void Add(UserModel entity)
        {
            _database.Entry(entity).State = EntityState.Added;
        }

        public override void Delete(UserModel entity)
        {
            _database.Entry(entity).State = EntityState.Deleted;
        }

        public override void Edit(UserModel entity)
        {
            _database.Entry(entity).State = EntityState.Modified;
        }

        public override List<UserModel> GetAll()
        {
            return _database.Users.ToList();
        }

        public override List<UserModel> GetAll(Expression<Func<UserModel, bool>> predicate)
        {
            return _database.Users.Where(predicate).ToList();
        }

        public override UserModel GetById(int id)
        {
            return _database.Users.Find(id);
        }

        public UserModel GetByLogin(string login)
        {
            return _database.Users.Single(u => u.Login == login);
        }

        public override void Save()
        {
            _database.SaveChanges();
        }
    }
}
