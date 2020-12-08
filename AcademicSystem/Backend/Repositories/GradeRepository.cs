using AcademicSystem.Backend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicSystem.Backend.Repositories
{
    public class GradeRepository
    {
        private SqlConnection conn;

        public GradeRepository()
        {
            conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        }


        public List<Grade> GetGrades(string student_id)
        {
            List<Grade> gradesList = new List<Grade>();
            try
            {
                string sql = "select id, subject_id, student_id, grade, group_id from grade " +
                        "where student_id=@student_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@student_id", student_id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int sub_id = int.Parse(reader["subject_id"].ToString());
                    int stud_id = int.Parse(reader["student_id"].ToString());
                    int grade = int.Parse(reader["grade"].ToString());
                    int gro_id = int.Parse(reader["group_id"].ToString());
                    gradesList.Add(new Grade(id, sub_id, stud_id, grade, gro_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return gradesList;
        }

        public void RemoveGrades(string userid)
        {
            try
            {
                string sql = "delete from grade " +
                         "where student_id=@student_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@student_id", userid);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grades have been removed.");
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


        public void RemoveGradesTeacher(string subjectid)
        {
            try
            {
                string sql = "delete from grade " +
                         "where subject_id=@subject_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@subject_id", subjectid);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grades have been removed.");
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
