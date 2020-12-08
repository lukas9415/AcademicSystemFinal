using AcademicSystem.Backend.Repositories;
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
    public partial class RemoveSubject : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;

        DataTable dt1;
        SqlDataAdapter da1;
        DataSet ds1;
        public RemoveSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fid;
            bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out fid);
            SubjectRepository repository = new SubjectRepository();
            repository.RemoveSubject(fid);
            SubjectRefresh();
            this.subjectTableAdapter.Fill(this.academicDataSet.subject);
        }

        private void RemoveSubject_Load(object sender, EventArgs e)
        {
            this.subjectTableAdapter.Fill(this.academicDataSet.subject);
            //Fills teachers--------------------------------------------------
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Surname", 70, HorizontalAlignment.Center);
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
            }


            //Fills subjects----------------------------------------------
            listView2.Clear();
            listView2.Columns.Add("ID", 40);
            listView2.Columns.Add("Name", 210, HorizontalAlignment.Center);
            listView2.Columns.Add("Group ID", 70, HorizontalAlignment.Right);
            listView2.Columns.Add("Teacher ID", 70, HorizontalAlignment.Right);
            listView2.View = View.Details;

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from subject", conn);
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

        public void SubjectRefresh()
        {
            listView2.Clear();
            listView2.Columns.Add("ID", 40);
            listView2.Columns.Add("Name", 210, HorizontalAlignment.Center);
            listView2.Columns.Add("Group ID", 70, HorizontalAlignment.Right);
            listView2.Columns.Add("Teacher ID", 70, HorizontalAlignment.Right);
            listView2.View = View.Details;

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from subject", conn);
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

        private void subjectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void subjectBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
