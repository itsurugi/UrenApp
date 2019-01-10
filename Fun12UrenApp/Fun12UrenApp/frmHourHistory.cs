using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fun12UrenApp.Classes;

namespace Fun12UrenApp
{
    public partial class frmHourHistory : Form
    {
        User employee;
        Database dbclass;
        List<Hoursheet> hoursheets = new List<Hoursheet>();
        public frmHourHistory(User user, Database dbclass)
        {
            InitializeComponent();
            employee = user;
            this.dbclass = dbclass;
            LoadData();
        }

        public void LoadData()
        {
            hoursheets = dbclass.ReturnHoursheets(employee.Userid);
            foreach(Hoursheet sheet in hoursheets)
            {
                dgvHoursheetDisplay.Rows.Add(sheet.Hoursheetid, sheet.TotalWorked, sheet.Entered);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
