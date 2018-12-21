using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Login
    {
        Database dbclass = new Database();
        public bool LoginCheck(string username, string password)
        {
            bool LoginState = false;
            User user = dbclass.Login(username, password);
            if(user.Username != null)
            {
                LoginState = true;
            }
            return LoginState;
        }
    }
}
