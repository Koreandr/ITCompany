using ITCompany_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Models
{
   public class ProjectManagerModel
    {
        public int Id { get; set; }
        public string Name_PM { get; set; }
        public virtual ProjectTasksModel ProjectTasksModel { get; set; }
        public virtual UserModel Users { get; set; }

        public ProjectManagerModel()
        {

        }
        public override string ToString()
        {
            return Name_PM;
        }
    }
}
