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
    public partial class frmLogin : Form
    {
        Login login = new Login();
        frmMenu menu = new frmMenu();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(login.LoginCheck(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("woopwoop");
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boo");
            }
        }
    }
}
