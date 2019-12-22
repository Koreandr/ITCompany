using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Model
{
    class UserModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public bool Hr { get; set; }
        public bool Pm { get; set; }

        public UserModel(string login, string password, bool admin, bool hr, bool pm)
        {
            Login = login;
            Password = password;
            Admin = admin;
            Hr = hr;
            Pm = pm;
        }




    }
}
