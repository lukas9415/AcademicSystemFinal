using AcademicSystem.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Backend.Repositories
{
    public class GroupRepository
    {
        private SqlConnection conn;

        public GroupRepository()
        {
            conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        }


       public string GetGroupName(string id)
        {
            try
            {
                string groupName = "";
                conn.Open();
                string sql = "select id, name from groups " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@id", id);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    groupName = sReader["name"].ToString();
                }
                return groupName;

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


        public void AddGroup(string name)
        {
            try
            {
                string sql = "insert into groups(name) " +
                                   "values (@name)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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
