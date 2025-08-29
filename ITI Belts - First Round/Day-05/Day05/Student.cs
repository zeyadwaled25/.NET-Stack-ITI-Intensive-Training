using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Student
    {
        public string Name;
        public double Grade;

        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.Grade > s2.Grade;
        }
        public static bool operator <(Student s1, Student s2)
        {
            return s1.Grade < s2.Grade;
        }

        public static bool operator >=(Student s1, Student s2)
        {
            return s1.Grade >= s2.Grade;
        }
        public static bool operator <=(Student s1, Student s2)
        {
            return s1.Grade <= s2.Grade;
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name} , Grade : {Grade}");
        }
    }
}
