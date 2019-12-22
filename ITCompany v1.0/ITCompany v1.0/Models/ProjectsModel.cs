using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Models
{
    ///<summary> Project Model from DataBase
    ///</summary>
    public class ProjectsModel
    {
        public int Id { get; set; }
        public string Name_Project { get; set; }
        public int Price { get; set; }

        public virtual ICollection<ProjectTasksModel> ProjectTasks { get; set; }

        public ProjectsModel()
        {

        }

        public override string ToString()
        {
            return Name_Project;
        }
    }
}
