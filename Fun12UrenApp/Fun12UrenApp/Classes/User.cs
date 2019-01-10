using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class User
    {
        public int Userid { get; set; } 
        public string Username { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public bool Activated { get; set; }
        public List<Agreement> Agreements { get; set; } = new List<Agreement>();
        public List<Project> Projects { get; set; } = new List<Project>();

        public User()
        {

        }
        public User(int userid, string username, string firstname, string lastname, string role, bool blocked, List<Agreement> agreements)
        {
            this.Userid = userid;
            this.Username = username;
            this.Name = firstname + " " + lastname;
            this.Role = role;
            this.Activated = blocked;
            this.Agreements = agreements;
        }

        public int Getprojectid(string name)
        {
            int projectid = 0;
            foreach(Project project in Projects)
            {
                if(project.Projectname == name)
                {
                    projectid = project.Projectnr;
                    break;
                }
            }
            return projectid;
        }
    }
}
