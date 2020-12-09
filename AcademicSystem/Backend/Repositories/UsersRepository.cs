using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using LoginApp;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginApp
{
    public class UsersRepository
    {
        private static List<User> usersList;

        private SqlConnection conn;

        public List<User> GetUsers()
        {
            return usersList;
        }

        public UsersRepository()
        {
            conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        }

        public void RegisterStudent(User user)
        {
            try
            {
                string sql = "insert into [user](name, surname, birthdate, username, password, type, group_id) " +
                    "values (@name, @surname, @birthdate, @username, @password, @type, @group_id)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@surname", user.GetSurname());
                cmd.Parameters.AddWithValue("@username", user.GetUserName());
                cmd.Parameters.AddWithValue("@password", user.GetPassword());
                cmd.Parameters.AddWithValue("@type", "Student");
                cmd.Parameters.AddWithValue("@birthdate", user.GetBirthdate());
                cmd.Parameters.AddWithValue("@group_id", user.GetGroupId());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }


        public void RegisterTeacher(User user)
        {
            try
            {
                string sql = "insert into [user](name, surname, birthdate, username, password, type) " +
                    "values (@name, @surname, @birthdate, @username, @password, @type)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@surname", user.GetSurname());
                cmd.Parameters.AddWithValue("@username", user.GetUserName());
                cmd.Parameters.AddWithValue("@password", user.GetPassword());
                cmd.Parameters.AddWithValue("@type", "Teacher");
                cmd.Parameters.AddWithValue("@birthdate", user.GetBirthdate());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public User Login(string username, string password)
        {
            try
            {
                string sql = "select name, surname, birthdate, username, password, type, group_id from [user] " +
                        "where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        DateTime date = DateTime.Parse(reader["birthdate"].ToString());
                        string usrname = reader["username"].ToString();
                        string pass = reader["password"].ToString();
                        string type = reader["type"].ToString();
                        string group_id = reader["group_id"].ToString();
                        return new User(name, surname, date, usrname, pass, type, group_id);
                    }
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            throw new Exception("Bad credentials");
        }

        public void RemoveStudent(string id)
        {
                try
                {
                    string sql = "delete from [user] " +
                             "where id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student has been succesfully removed.");
                }
                catch (Exception exc)
                {
                    throw new Exception(exc.Message);
                }
                finally
                {
                    conn.Close();
                }
        }

        public void CheckStudent(string id)
        {
            try
            {
                string sql = "select count(*) from [user] " +
                         "where id=@id and type='Student'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if(count == 0)
                {
                    throw new Exception("Student does not exist!");
                }

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void RemoveTeacher(string id)
        {
            try
            {
                string sql = "delete from [user] " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher has been succesfully removed.");
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CheckTeacher(string id)
        {
            try
            {
                string sql = "select count(*) from [user] " +
                         "where id=@id and type='Teacher'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    throw new Exception("Teacher does not exist!");
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void CheckLogin(string username)
        {
            try
            {
                string sql = "select name, surname, birthdate, username, password, type, group_id from [user] " +
                        "where username=@username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string usrname = reader["username"].ToString();
                        if(username == usrname)
                        {
                            throw new Exception("User with the same username exists");
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        /*
        public string GetUsername(string userid)
        {
            try
            {
                string username = "";
                conn.Open();
                string sql = "select userId, name, surname, birthdate, username, password, usertyp, image from [user] " +
                         "where userId=@userId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@userId", userid);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    username = sReader["username"].ToString();
                }
                return username;

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        */

        public string GetUserId(string username)
        {
            try
            {
                string userid = "";
                conn.Open();
                string sql = "select id, name, surname, birthdate, username, password, type, group_id from [user] " +
                         "where username=@username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@username", username);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    userid = sReader["id"].ToString();
                }
                return userid;

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public string GetNameSurname(string userid)
        {
            try
            {
                string username = "";
                conn.Open();
                string sql = "select id, name, surname, birthdate, username, password, type, group_id from [user] " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@id", userid);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    username = sReader["name"].ToString() + " " + sReader["surname"].ToString();
                }
                return username;

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetUserGroup(string userid)
        {
            try
            {
                string group_id = "";
                conn.Open();
                string sql = "select id, name, surname, birthdate, username, password, type, group_id from [user] " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@id", userid);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    group_id = sReader["group_id"].ToString();
                }
                return group_id;

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }






    }
}
