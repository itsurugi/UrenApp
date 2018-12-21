using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun12UrenApp.Classes
{
    public class User
    {
        string username;
        public User()
        {

        }
        public User(string username)
        {
            this.Username = username;
        }

        public string Username { get => username; set => username = value; }
    }
}
