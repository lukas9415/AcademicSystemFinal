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
    public partial class RemoveGroup : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=academic;User ID=sa;Password=123456");
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public RemoveGroup()
        {
            InitializeComponent();
        }

        private void RemoveGroup_Load(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Fill(this.academicDataSet.groups);

            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            listView1.View = View.Details;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from groups", conn);
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
            }
        }


        public void GroupRefresh()
        {
            listView1.Clear();
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            listView1.View = View.Details;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from groups", conn);
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fid;
            bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out fid);

            GroupRepository repository = new GroupRepository();
            repository.RemoveGroup(fid);
            GroupRefresh();
            this.groupsTableAdapter.Fill(this.academicDataSet.groups);
        }
    }
}
