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
    public class SubjectRepository
    {
        private SqlConnection conn;

        public SubjectRepository()
        {
            conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        }

        /*
        public List<Subject> GetSubjects()
        {
            List<Subject> subjectList = new List<Subject>();
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
        */

        public string GetSubjectName(string id)
        {
            try
            {
                string subjectName = "";
                conn.Open();
                string sql = "select id, name, group_id, teacher_id from subject " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@id", id);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    subjectName = sReader["name"].ToString();
                }
                return subjectName;
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


        public string GetSubjectTeacher(string id)
        {
            try
            {
                string subjectTeacher = "";
                conn.Open();
                string sql = "select id, name, group_id, teacher_id from subject " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@id", id);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    subjectTeacher = sReader["teacher_id"].ToString();
                }
                return subjectTeacher;
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

        public void AddSubject(string name, int group_id, int teacher_id)
        {
            try
            {
                string sql = "insert into subject(name, group_id, teacher_id) " +
                                   "values (@name, @group_id, @teacher_id)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@group_id", group_id);
                cmd.Parameters.AddWithValue("@teacher_id", teacher_id);
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


        public void RemoveSubject(int id)
        {
            try
            {
                string sql = "delete from subject " +
                         "where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject has been removed.");
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


        public string FindSubjectId(string teacherid)
        {
            try
            {
                string subjectId = "";
                conn.Open();
                string sql = "select id, name, group_id, teacher_id from subject " +
                         "where teacher_id=@teacher_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sReader;
                cmd.Parameters.AddWithValue("@teacher_id", teacherid);
                sReader = cmd.ExecuteReader();
                if (sReader.Read())
                {
                    subjectId = sReader["id"].ToString();
                }
                return subjectId;
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
