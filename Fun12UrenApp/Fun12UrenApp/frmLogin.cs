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
        Database dbclass = new Database();
        Login login = new Login();
        
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            User user = login.ReturnUserData(txtUsername.Text, txtPassword.Text, dbclass);
            frmMenu menu = new frmMenu(user, dbclass);
            if (user != null)
            {
                MessageBox.Show("woopwoop");
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Boo");
            }
        }
    }
}
