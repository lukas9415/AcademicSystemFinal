using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Backend.Models
{
    public class Group
    {
        public int GroupId { get; private set; }
        public string GroupName { get; private set; }


        public Group(int groupid, string groupname)
        {
            GroupId = groupid;
            GroupName = groupname;
        }
    }
}
