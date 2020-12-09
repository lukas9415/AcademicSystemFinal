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

        public AddGrades()
        {
            InitializeComponent();
        }

        private void AddGrades_Load(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Fill(this.academicDataSet.groups);

            
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
    }
}
