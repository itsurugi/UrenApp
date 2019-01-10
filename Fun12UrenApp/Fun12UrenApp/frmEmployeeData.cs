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
    public partial class frmEmployeeData : Form
    {
        User employee;
        public frmEmployeeData(User user)
        {
            InitializeComponent();
            employee = user;
            LoadData();
        }

        public void LoadData()
        {
            lblEmpName.Text = "Naam: " + employee.Name;
            foreach(Agreement agreement in employee.Agreements)
            {
                dgvAgreements.Rows.Add(agreement.Totalhours, agreement.Startdate.ToString("dd/MM/yy"), agreement.Enddate.ToString("dd/MM/yy"), agreement.Travelrefund, agreement.Hourprice, agreement.Kmprice);
            }
            foreach(Project project in employee.Projects)
            {
                dgvProjects.Rows.Add(project.Projectname, project.Projectnr, project.Projectlocation);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
