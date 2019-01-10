using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Agreement
    {
        public int Totalhours { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public bool Travelrefund { get; set; }
        public decimal Hourprice { get; set; }
        public decimal Hourpriceoverdue { get; set; }
        public decimal Kmprice { get; set; }

        public Agreement(int totalhours, DateTime startdate, DateTime enddate, bool travelrefund, decimal hourprice, decimal hourpriceoverdue, decimal kmprice)
        {
            this.Totalhours = totalhours;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.Travelrefund = travelrefund;
            this.Hourprice = hourprice;
            this.Hourpriceoverdue = Hourpriceoverdue;
            this.Kmprice = kmprice;
        }
    }
}
