using ITCompany_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Model
{
    ///<summary> User Model from DataBase
    ///</summary>
     public class UserModel
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? Departament_Id { get; set; }

        public virtual DepartamentsModel Departaments { get; set; }

        public string Role { get; set; }
        public bool Admin { get; set; }
        public bool Hr { get; set; }
        public bool Pm { get; set; }
        public bool User { get; set; }


        public UserModel(string login, string password, bool admin, bool hr, bool pm, bool user)
        {
            Login = login;
            Password = password;
            Admin = admin;
            Hr = hr;
            Pm = pm;
            User = user;
        }

        public UserModel() { }

        public override string ToString()
        {
            return Name;
        }




    }
}
