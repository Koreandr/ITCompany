using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Model
{
    class UserCreateModel
    {
        public HashSet<UserModel> Users { get; private set; }
        private static UserCreateModel userStorage;

        public static UserCreateModel GetUser()
        {
            return userStorage = new UserCreateModel ();
        }

        private UserCreateModel()
        {
            Users = new HashSet<UserModel>
            {
                new UserModel("admin","admin",true,false,false),
                new UserModel("user","user",false,false,false),
                new UserModel("hr","hr",false,true,false),
                new UserModel("pm","pm",false,false,true)
            };
        }

        internal UserModel SearchUser(object text, object p)
        {
            throw new NotImplementedException();
        }

        public UserModel SearchUser(string login, string password)
        {
            UserModel user = (from u in Users
                         where u.Login.Equals(login)
                         && u.Password.Equals(password)
                         select u).FirstOrDefault();
            return user;
        }
    }
}
