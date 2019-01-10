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
    public partial class frmInsertHours : Form
    {
        Database dbclass;
        User employee = new User();
        List<Hourline> hourlist = new List<Hourline>();
        Hoursheet hoursheet;
        public frmInsertHours(User user, Database dbclass)
        {
            InitializeComponent();
            this.dbclass = dbclass;
            employee = user;
            InitData();

        }

        public void InitData()
        {
            foreach(Project project in employee.Projects)
            {
                cmbProject.Items.Add(project.Projectname);
            }
            hoursheet = new Hoursheet(employee.Userid);
            cmbHourtype.DataSource = Enum.GetValues(typeof(Hourtype));
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnInsertHourline_Click(object sender, EventArgs e)
        {
            Hourline hourline = new Hourline(
                int.Parse(txtHours.Text), 
                DateTime.Parse(dtWorkday.Text), 
                int.Parse(txtTravel.Text), 
                employee.Getprojectid(cmbProject.SelectedItem.ToString()), 
                (Hourtype)cmbHourtype.SelectedItem);
            hoursheet.AddHourline(hourline);
            this.dataGridView1.Rows.Add(DateTime.Parse(dtWorkday.Text).ToString("dd/MM/yy"), txtHours.Text, cmbProject.Text, txtTravel.Text, cmbHourtype.Text);
        }

        private void btnInsertHoursheet_Click(object sender, EventArgs e)
        {
            dbclass.InsertHoursheet(hoursheet);
        }
    }
}
