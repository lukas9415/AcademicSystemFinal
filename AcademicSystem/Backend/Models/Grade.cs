using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Backend.Models
{
    public class Grade
    {
        public int Id { get; private set; }
        public int Subject_Id { get; private set; }
        public int Student_Id { get; private set; }
        public int GradeValue { get; private set; }
        public int Group_Id { get; private set; }


        public Grade(int id, int subject_id, int student_id, int gradevalue, int group_id)
        {
            Id = id;
            Subject_Id = subject_id;
            Student_Id = student_id;
            GradeValue = gradevalue;
            Group_Id = group_id;
        }
    }
}
