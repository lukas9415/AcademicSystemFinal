using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicSystem.Backend.Models;
using AcademicSystem.Backend.Repositories;
using LoginApp;

namespace AcademicSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            GroupRepository repository = new GroupRepository();
            groupHere.Text = repository.GetGroupName(Form1.LoggedInUser.GetGroupId());
            nameHere.Text = Form1.LoggedInUser.GetName() + " " + Form1.LoggedInUser.GetSurname();

            if (Form1.LoggedInUser.GetUserType() == "Admin")
            {
                adminButton.Visible = true;
                studentButton.Visible = false;
                teacherButton.Visible = false;
                groupHere.Visible = false;
                welcomeText.Visible = false;
            }
            if (Form1.LoggedInUser.GetUserType() == "Teacher")
            {
                adminButton.Visible = false;
                studentButton.Visible = false;
                teacherButton.Visible = true;
                groupHere.Visible = false;
                welcomeText.Visible = false;
            }
            if (Form1.LoggedInUser.GetUserType() == "Student")
            {
                adminButton.Visible = false;
                studentButton.Visible = true;
                teacherButton.Visible = false;
                welcomeText.Visible = true;

                UsersRepository repository3 = new UsersRepository();
                string userid = repository3.GetUserId(Form1.LoggedInUser.GetUserName());


                GradeRepository repository1 = new GradeRepository();
                List<Grade> gradesList = repository1.GetGrades(userid);

                foreach (Grade grade in gradesList)
                {
                    GradeInfo wc = new GradeInfo(grade);
                    flowLayoutPanel1.Controls.Add(wc);
                }
            }

        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupHere_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.LoggedInUser = null;
            Form1 fc = new Form1();
            fc.Show();
            this.Close();
        }

        private void registerNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent a = new RegisterStudent();
            a.ShowDialog();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent a = new RemoveStudent();
            a.ShowDialog();
        }

        private void registerTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterTeacher a = new RegisterTeacher();
            a.ShowDialog();
        }

        private void addNewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject a = new AddSubject();
            a.ShowDialog();
        }

        private void removeSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSubject a = new RemoveSubject();
            a.ShowDialog();
        }

        private void removeTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTeacher a = new RemoveTeacher();
            a.ShowDialog();
        }

        private void addNewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup a = new AddGroup();
            a.ShowDialog();
        }
    }
}
