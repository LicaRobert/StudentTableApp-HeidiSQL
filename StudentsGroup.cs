using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class StudentsGroup
    {
        public StudentsGroup()
        {
            group = new List<Student>();
        }

        public Boolean addStudent(Student student)
        {
            if (!group.Contains(student))
            {
                group.Add(student);
                return true;
            }
            return false;
        }

        List<Student> group;
    }
}
