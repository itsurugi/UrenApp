using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Hourline
    {
        public int Hours { get; set; }
        public DateTime Date { get; set; }
        public int Traveldistance { get; set; }
        public int Project { get; set; }
        public Hourtype Hourtype { get; set; }

        public Hourline(int Hours, DateTime Date, int Traveldistance, int Project, Hourtype Hourtype)
        {
            this.Hours = Hours;
            this.Date = Date;
            this.Traveldistance = Traveldistance;
            this.Project = Project;
            this.Hourtype = Hourtype;
        }
    }
}
