using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun12UrenApp
{
    public partial class frmCreateTemplate : Form
    {
        public frmCreateTemplate()
        {
            InitializeComponent();
            InitLv();
        }

        public void InitLv()
        {
            this.dataGridView1.Rows.Add("Maandag", "8", "Project1", "25", "Intern");
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void btnInsertHourline_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(cmbDays.Text, txtHours.Text, cmbProject.Text, txtTravel.Text, cmbHourtype.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
