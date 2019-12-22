using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany_v1._0.Models
{
    public class TasksModel
    {
        public int Id { get; set; }
        public string Name_Task { get; set; }
        public string Description { get; set; }      
        public int Status { get; set; }

        public virtual ICollection<ProjectTasksModel> ProjectTasks { get; set; }
    }
}
