using LoginApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int fid;
                bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out fid);
                User user = new User(nameTextBox.Text, surnameTextBox.Text, dateTimePicker1.Value, nameTextBox.Text.ToLower() + "." + surnameTextBox.Text.ToLower(), surnameTextBox.Text.ToLower(), "Student", fid.ToString());
                UsersRepository repository = new UsersRepository();
                user.GetType();
                user.SetUserType("Student");
                repository.CheckLogin(nameTextBox.Text.ToLower() + "." + surnameTextBox.Text.ToLower());
                //repository.CheckLogin(usernameTextBox.Text);
                repository.RegisterStudent(user);
                nameTextBox.Clear();
                surnameTextBox.Clear();
                MessageBox.Show("Registration succesfull! Student may now log in");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'academicDataSet.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.academicDataSet.groups);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
