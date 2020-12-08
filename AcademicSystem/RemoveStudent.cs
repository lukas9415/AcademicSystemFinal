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
    public partial class RemoveStudent : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("select * from [user] where type = 'Student' ", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "testTable");
            conn.Close();

            dt = ds.Tables["testTable"];
            int i;
            for (i=0; i<=dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString().Substring(0,10));
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
            }
        }



        private void StudentsRefresh()
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
            SqlCommand cmd = new SqlCommand("select * from [user] where type = 'Student' ", conn);
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
            DialogResult dr = MessageBox.Show("Are you sure to delete this student? All grades will be removed", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    GradeRepository repository1 = new GradeRepository();
                    UsersRepository repository = new UsersRepository();
                    repository.CheckStudent(textBox1.Text);
                    repository1.RemoveGrades(textBox1.Text);
                    repository.RemoveStudent(textBox1.Text);
                    StudentsRefresh();
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
