using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ITCompany_v1._0.Model
{
    class AdminModel
    {

        public class Project
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string PM{ get; set; }
            public int dedline { get; set; }
        }
        public class MobileContext : DbContext
        {
            public MobileContext() : base("DefaultConnection")
            {

            }
            public DbSet<Project> Project { get; set; }
        }



    }
}
