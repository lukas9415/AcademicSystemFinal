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
    public partial class RemoveTeacher : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public RemoveTeacher()
        {
            InitializeComponent();
        }

        private void RemoveTeacher_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Surname", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Birthdate", 90, HorizontalAlignment.Center);
            listView1.Columns.Add("Username", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Password", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Type", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Group ID", 70, HorizontalAlignment.Right);
            listView1.View = View.Details;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [user] where type = 'Teacher' ", conn);
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
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString().Substring(0, 10));
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
            }
        }

        public void TeacherRefresh()
        {
            listView1.Clear();
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Surname", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Birthdate", 90, HorizontalAlignment.Center);
            listView1.Columns.Add("Username", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Password", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Type", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Group ID", 70, HorizontalAlignment.Right);
            listView1.View = View.Details;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [user] where type = 'Teacher' ", conn);
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
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString().Substring(0, 10));
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this teacher? All grades and subjects from this teacher will be removed", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    SubjectRepository repository2 = new SubjectRepository();
                    GradeRepository repository1 = new GradeRepository();
                    UsersRepository repository = new UsersRepository();

                    int fid;
                    bool parseOK = Int32.TryParse(repository2.FindSubjectId(textBox1.Text).ToString(), out fid);

                    repository.CheckTeacher(textBox1.Text);
                    repository1.RemoveGradesTeacher(repository2.FindSubjectId(textBox1.Text));
                    repository2.RemoveSubject(fid);
                    repository.RemoveTeacher(textBox1.Text);
                    TeacherRefresh();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error message: " + exc.Message);
                }
            }
            else if (DialogResult == DialogResult.No)
            {
                //Nothing
            }
        }
    }
}
