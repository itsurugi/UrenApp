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
        string connectionstring = "server=localhost;database=fun12;uid=root;pwd=;SslMode=none;";

        public Database() //constructor 
        {
            OpenConnection();
        }
        ~Database() //finalizer
        {
            CloseConnection();
        }

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
            try
            { 
                command = dbconnect.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from user where email = '" + username + "' and password = '" + password + "'";
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User(reader.GetString("email"));
                    }
                }
            }
            catch(Exception)
            {
                user = null;
            }
            
            
            return user;
        }

    }
}
