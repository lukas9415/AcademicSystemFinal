using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademicSystem.Backend.Models;
using AcademicSystem.Backend.Repositories;
using LoginApp;

namespace AcademicSystem
{
    public partial class GradeInfo : UserControl
    {
        public GradeInfo(Grade grade)
        {
            InitializeComponent();

            nameHere.Text = grade.Subject_Id.ToString();
            gradeHere.Text = grade.GradeValue.ToString();
        }

        private void GradeInfo_Load(object sender, EventArgs e)
        {
            string subjectIdSave = nameHere.Text;
            SubjectRepository repository = new SubjectRepository();
            nameHere.Text = repository.GetSubjectName(subjectIdSave);

            UsersRepository repository1 = new UsersRepository();
            teacherHere.Text = repository1.GetNameSurname(repository.GetSubjectTeacher(subjectIdSave));
        }
    }
}
