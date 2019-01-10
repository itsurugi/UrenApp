using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class Login
    {

        public bool LoginCheck(User user)
        {
            bool LoginState = false;
            if (user.Username != null)
            {                
                LoginState = true;
            }
            else
            {
                LoginState = false;
            }
            return LoginState;
        }

        public User ReturnUserData(string username, string password, Database dbclass)
        {
            User user = dbclass.Login(username, password);

            if (LoginCheck(user))
            {
                user.Agreements = dbclass.GetAgreements(user.Userid);
                user.Projects = dbclass.GetProjects(user.Userid);
            }
            else
            {
                user = null;
            }
            return user;
        }
    }
}
