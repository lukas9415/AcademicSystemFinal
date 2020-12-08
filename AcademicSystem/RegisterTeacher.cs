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
    public partial class RegisterTeacher : Form
    {
        public RegisterTeacher()
        {
            InitializeComponent();
        }

        private void RegisterTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'academicDataSet.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.academicDataSet.subject);
            //test

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(nameTextBox.Text, surnameTextBox.Text, dateTimePicker1.Value, nameTextBox.Text.ToLower() + "." + surnameTextBox.Text.ToLower(), surnameTextBox.Text.ToLower(), "Teacher", null);
                UsersRepository repository = new UsersRepository();
                user.GetType();
                user.SetUserType("Teacher");
                repository.CheckLogin(nameTextBox.Text.ToLower() + "." + surnameTextBox.Text.ToLower());
                repository.RegisterTeacher(user);
                nameTextBox.Clear();
                surnameTextBox.Clear();
                MessageBox.Show("Registration succesfull! Teacher may now log in");
                nameTextBox.Clear();
                surnameTextBox.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }
    }
}
