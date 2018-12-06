using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Login
    {
        public bool LoginCheck(string username, string password)
        {
            bool LoginState = false;
            if(username == "admin" && password == "admin")
            {
                User user = new User(username);
                LoginState = true;
            }
            return LoginState;
        }
    }
}
