using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Fun12UrenApp.Classes
{
    public class Database
    {
        MySqlConnection dbconnect;
        MySqlCommand command;
        MySqlDataReader reader;
        string connectionstring = "server=localhost;database=fun;uid=root;pwd=;SslMode=none;";

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

        public List<Hoursheet> ReturnHoursheets(int userid)
        {
            List<Hoursheet> hoursheets = new List<Hoursheet>();
            List<int> hoursheetid = new List<int>();
            try
            {
                command = dbconnect.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM hoursheet WHERE user_id = @userid";
                command.Parameters.AddWithValue("@userid", userid);
                command.Prepare();
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hoursheetid.Add(reader.GetInt32("hoursheet_id"));
                        
                        
                    }
                }
                foreach(int x in hoursheetid)
                {
                    try
                    {
                        command = dbconnect.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "SELECT hoursheet.entered, hoursheet.hoursheet_id, hoursheet.user_id, (SELECT SUM(hours) FROM hourline WHERE hoursheet_id = @hoursheetid) AS Totalworkedhours FROM hoursheet WHERE hoursheet_id = @hoursheetid ORDER BY entered ASC";
                        command.Parameters.AddWithValue("@hoursheetid", x);
                        command.Prepare();
                        command.ExecuteNonQuery();
                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hoursheets.Add(new Hoursheet(reader.GetInt32("user_id"), reader.GetInt32("totalworkedhours"), reader.GetInt32("hoursheet_id"), reader.GetDateTime("entered")));
                            }
                        }
                    }
                    catch(Exception exc)
                    {
                        throw exc;
                    }
                    
                   
                }
            }
            catch (Exception)
            {
                
            }
            return hoursheets;
        }

        public void InsertHoursheet(Hoursheet hoursheet)
        {
            try
            {
                command = dbconnect.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO hoursheet (user_id, entered) VALUES (@userid, @entered)";
                command.Parameters.AddWithValue("@userid", hoursheet.Userid);
                command.Parameters.AddWithValue("@entered", DateTime.Now);

                command.Prepare();
                command.ExecuteNonQuery();

                command.Parameters.Add(new MySqlParameter("@hoursheet", command.LastInsertedId));
                int id = Convert.ToInt32(command.Parameters["@hoursheet"].Value);


                foreach (Hourline hourline in hoursheet.Hourlines)
                {
                    command = dbconnect.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO hourline (hours, date, traveldistance, hourtype, hoursheet_id, project_id) VALUES (@hours, @date, @traveldistance, @hourtype, @hoursheetid, @projectid)";
                    command.Parameters.AddWithValue("@hours", hourline.Hours);
                    command.Parameters.AddWithValue("@date", hourline.Date);
                    command.Parameters.AddWithValue("@traveldistance", hourline.Traveldistance);
                    command.Parameters.AddWithValue("@hourtype", hourline.Hourtype);
                    command.Parameters.AddWithValue("@hoursheetid", id);
                    command.Parameters.AddWithValue("@projectid", hourline.Project);

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public User Login(string username, string password)
        {
            User user = new User();
            List<Agreement> agreements = new List<Agreement>();
            try
            { 
                command = dbconnect.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM user WHERE email = @username AND password = @password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Prepare();
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user = new User(reader.GetInt32("user_id"), reader.GetString("email"), reader.GetString("firstname"), reader.GetString("lastname"), reader.GetString("role"), reader.GetBoolean("blocked"), agreements);
                    }
                }
            }
            catch(Exception)
            {
                user = null;
            }

            return user;
        }

        public List<Agreement> GetAgreements(int userid)
        {
            List<Agreement> agreements = new List<Agreement>();
            try
            {
                
                command = dbconnect.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM agreement WHERE user_id = @userid AND enddate > @currentdate";
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@currentdate", DateTime.Today);
                command.Prepare();
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        agreements.Add(new Agreement(reader.GetInt32("totalhours"), reader.GetDateTime("startdate"), reader.GetDateTime("enddate"), reader.GetBoolean("travelrefund"), reader.GetDecimal("hourprice"), reader.GetDecimal("hourpriceoverdue"), reader.GetDecimal("kmprice")));
                    }
                }
            }
            catch (Exception)
            {

            }
            
            return agreements;
        }

        public List<Project> GetProjects(int userid)
        {
            List<Project> projects = new List<Project>();
            try
            {

                command = dbconnect.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM project_has_user INNER JOIN project ON project_has_user.project_id = project.id WHERE user_id = @userid";
                command.Parameters.AddWithValue("@userid", userid);
                command.Prepare();
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        projects.Add(new Project(reader.GetInt32("projectnr"), reader.GetString("name"), reader.GetString("location")));
                    }
                }
            }
            catch (Exception)
            {

            }


            return projects;
        }

    }
}
