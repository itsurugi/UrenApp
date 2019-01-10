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
    public partial class frmMenu : Form
    {
        Database dbclass;
        User employee = new User();
        public frmMenu(User user, Database dbclass)
        {
            InitializeComponent();
            employee = user;
            LoadData();
            this.dbclass = dbclass;
        }

        public void LoadData()
        {
            lblUsername.Text = employee.Name;
            lblTotalhours.Text = "Aantal werkuren: " + employee.Agreements[0].Totalhours;
        }

        private void btnInsertHours_Click(object sender, EventArgs e)
        {
            frmInsertHours inserthours = new frmInsertHours(employee, dbclass);
            this.Hide();
            inserthours.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            frmEmployeeData employeeinfo = new frmEmployeeData(employee);
            this.Hide();
            employeeinfo.ShowDialog();
            this.Show();
        }

        private void btnHourhistory_Click(object sender, EventArgs e)
        {
            frmHourHistory hourhistory = new frmHourHistory(employee, dbclass);
            this.Hide();
            hourhistory.ShowDialog();
            this.Show();
        }
    }
}
