using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student : IComparable, IEquatable<Student>
    {
        String Name { get; set; }
        String Gender { get; set; }
        long Age { get; set; }

        public Student(String name, String gender, long age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public String toString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;

            if (Name == other.Name)
            {
                if (Gender == other.Gender)
                {
                    if (Age == other.Age)
                    {
                        return 0;
                    }
                }
            }

            return 1;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Student objAsPart = obj as Student;

            if (objAsPart == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsPart);
            }
        }

        public bool Equals(Student other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.Name.Equals(other.Name));
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Name);
        }
    }
}
