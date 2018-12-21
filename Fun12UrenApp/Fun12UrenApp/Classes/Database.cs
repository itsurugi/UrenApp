using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fun12UrenApp.Classes
{
    public class Database
    {
        MySqlConnection dbconnect;
        MySqlCommand command;
        MySqlDataReader reader;
        string connectionstring = "server=localhost;database=logintest;uid=root;pwd=;SslMode=none;";

        public void OpenConnection()
        {
            dbconnect = new MySqlConnection(connectionstring);
            try
            {
                dbconnect.Open();
            }
            catch (Exception)
            {
                CloseConnection();
                throw;
            }
            
        }
        public void CloseConnection()
        {
            dbconnect.Close();
        }

        public User Login(string username, string password)
        {
            User user = new User();
            OpenConnection();
            MySqlCommand command = dbconnect.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from userinfo where username ='" + username + "' and password = '" + password + "'";
            command.ExecuteNonQuery();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                user = new User(reader.GetString("username"));
            }

            reader.Close();
           
            CloseConnection();

            return user;

        }
    }
}
