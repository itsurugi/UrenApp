using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Hoursheet
    {
        public int Userid { get; set; }
        public int Hoursheetid { get; set; }
        public int TotalWorked { get; set; }
        public DateTime Entered { get; set; }
        public List<Hourline> Hourlines { get; set; } = new List<Hourline>();

        public Hoursheet(int Userid)
        {
            this.Userid = Userid;
        }

        public Hoursheet(int userid, int totalworkedhours, int hoursheetid, DateTime entered)
        {
            this.Userid = Userid;
            this.TotalWorked = totalworkedhours;
            this.Hoursheetid = hoursheetid;
            this.Entered = entered;
        }

        public void AddHourline(Hourline hourline)
        {
            Hourlines.Add(hourline);
        }

        
    }
}
