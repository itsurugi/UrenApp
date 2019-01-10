using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Project
    {
        public int Projectnr { get; set; }
        public string Projectname { get; set; }
        public string Projectlocation { get; set; }

        public Project(int projectnr, string projectname, string projectlocation)
        {
            this.Projectnr = projectnr;
            this.Projectname = projectname;
            this.Projectlocation = projectlocation;
        }
    }
}
