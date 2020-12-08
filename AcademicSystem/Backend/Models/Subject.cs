using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Backend.Models
{
    public class Subject
    {
        public int Id { get; private set; }
        public string SubjectName { get; private set; }
        public int GroupId { get; private set; }
        public int TeacherId { get; private set; }


        public Subject(int id, string subjectname, int groupid, int teacherid)
        {
            Id = id;
            SubjectName = subjectname;
            GroupId = groupid;
            TeacherId = teacherid;
        }
    }
}
