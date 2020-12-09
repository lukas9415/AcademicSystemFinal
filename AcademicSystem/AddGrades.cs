using AcademicSystem.Backend.Repositories;
using LoginApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class AddGrades : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;


        DataTable dt1;
        SqlDataAdapter da1;
        DataSet ds1;


        DataTable dt2;
        SqlDataAdapter da2;
        DataSet ds2;

        public AddGrades()
        {
            InitializeComponent();
        }

        private void AddGrades_Load(object sender, EventArgs e)
        {
            BindData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            //Fills teachers--------------------------------------------------
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Surname", 70, HorizontalAlignment.Center);
            listView1.View = View.Details;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [user] where type = 'Student' and group_id=@group_id", conn);

            int fid;
            bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out fid);

            cmd.Parameters.AddWithValue("@group_id", fid);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "testTable");
            conn.Close();

            dt = ds.Tables["testTable"];
            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
            }




            //Fill Grades------------------------------
            listView2.Clear();
            listView2.Columns.Add("ID", 40);
            listView2.Columns.Add("Student ID", 70, HorizontalAlignment.Right);
            listView2.Columns.Add("Grade", 70, HorizontalAlignment.Right);
            listView2.Columns.Add("Group ID", 70, HorizontalAlignment.Right);
            listView2.View = View.Details;

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select id, student_id, grade, group_id from grade where subject_id=@subject_id and group_id=@group_id", conn);



            UsersRepository repository = new UsersRepository();
            string teacher_id = repository.GetUserId(Form1.LoggedInUser.GetUserName());

            SubjectRepository repository1 = new SubjectRepository();
            string subject_id = repository1.FindSubjectId(teacher_id);

            cmd1.Parameters.AddWithValue("@subject_id", subject_id);
            cmd1.Parameters.AddWithValue("@group_id", fid);
            da1 = new SqlDataAdapter(cmd1);
            ds1 = new DataSet();
            da1.Fill(ds1, "testTable1");
            conn.Close();

            dt1 = ds1.Tables["testTable1"];
            int j;
            for (j = 0; j <= dt1.Rows.Count - 1; j++)
            {
                listView2.Items.Add(dt1.Rows[j].ItemArray[0].ToString());
                listView2.Items[j].SubItems.Add(dt1.Rows[j].ItemArray[1].ToString());
                listView2.Items[j].SubItems.Add(dt1.Rows[j].ItemArray[2].ToString());
                listView2.Items[j].SubItems.Add(dt1.Rows[j].ItemArray[3].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            UsersRepository repository = new UsersRepository();
            string teacher_id = repository.GetUserId(Form1.LoggedInUser.GetUserName());


            conn.Open();
            SqlCommand cmd = new SqlCommand("select name, group_id from subject where teacher_id=@teacher_id", conn);
            da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            cmd.Parameters.AddWithValue("@teacher_id", teacher_id);
            da2.Fill(ds2);
            comboBox1.DataSource = ds2.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "group_id";
            comboBox1.Enabled = true;
            this.comboBox1.SelectedIndex = 0;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SubjectRepository repository1 = new SubjectRepository();
                UsersRepository repository = new UsersRepository();
                GradeRepository repository2 = new GradeRepository();
                string group_id = repository.GetUserGroup(textBox1.Text);
                string teacher_id = repository.GetUserId(Form1.LoggedInUser.GetUserName());
                string subject_id = repository1.FindSubjectId(teacher_id);
                repository2.CheckGrade(subject_id, textBox1.Text);
                repository1.CheckIfSubjectHasStudent(group_id, teacher_id);
                repository2.AddGrade(subject_id, textBox1.Text, textBox2.Text, group_id);
                GradeRefresh();
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }


        public void GradeRefresh()
        {
            int fid;
            bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out fid);

            //Fill Grades------------------------------
            listView2.Clear();
            listView2.Columns.Add("ID", 40);
            listView2.Columns.Add("Student ID", 70, HorizontalAlignment.Right);
            listView2.Columns.Add("Grade", 70, HorizontalAlignment.Right);
            listView2.Columns.Add("Group ID", 70, HorizontalAlignment.Right);
            listView2.View = View.Details;

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select id, student_id, grade, group_id from grade where subject_id=@subject_id and group_id=@group_id", conn);



            UsersRepository repository = new UsersRepository();
            string teacher_id = repository.GetUserId(Form1.LoggedInUser.GetUserName());

            SubjectRepository repository1 = new SubjectRepository();
            string subject_id = repository1.FindSubjectId(teacher_id);

            cmd1.Parameters.AddWithValue("@subject_id", subject_id);
            cmd1.Parameters.AddWithValue("@group_id", fid);
            da1 = new SqlDataAdapter(cmd1);
            ds1 = new DataSet();
            da1.Fill(ds1, "testTable1");
            conn.Close();

            dt1 = ds1.Tables["testTable1"];
            int j;
            for (j = 0; j <= dt1.Rows.Count - 1; j++)
            {
                listView2.Items.Add(dt1.Rows[j].ItemArray[0].ToString());
                listView2.Items[j].SubItems.Add(dt1.Rows[j].ItemArray[1].ToString());
                listView2.Items[j].SubItems.Add(dt1.Rows[j].ItemArray[2].ToString());
                listView2.Items[j].SubItems.Add(dt1.Rows[j].ItemArray[3].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;

            label8.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;

            label6.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SubjectRepository repository1 = new SubjectRepository();
                UsersRepository repository = new UsersRepository();
                GradeRepository repository2 = new GradeRepository();
                string group_id = repository.GetUserGroup(textBox1.Text);
                string teacher_id = repository.GetUserId(Form1.LoggedInUser.GetUserName());
                string subject_id = repository1.FindSubjectId(teacher_id);
                repository2.CheckGradeExistence(subject_id, textBox3.Text);
                repository2.RemoveGrade(textBox3.Text, subject_id);
                GradeRefresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }
    }
}
