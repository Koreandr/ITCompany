using ITCompany_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Models
{
    ///<summary> Departament Model from DataBase
    ///</summary>
    public class DepartamentsModel
    {
        public int Id { get; set; }
        public string Departament_Name { get; set; }
        public string Number_Of_Employee { get; set; }

        public virtual ICollection<UserModel> Users { get; set; }
    }
}
