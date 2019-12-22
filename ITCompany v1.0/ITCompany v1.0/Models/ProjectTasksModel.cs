using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Models
{
    public class ProjectTasksModel
    {
        public int Id { get; set; }

        public int? Project_Id { get; set; }
        public int? Tasks_Id { get; set; }
        public int? TasksModel_Id { get; set; }

        //public virtual ICollection<ProjectManagerModel> ProjectManager{ get; set; }
    }
}
