using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name)
        {
            Name = name;
            Age = 0;
        }

        public Student(string name, int age) : this(name)
        {
            Age = age;
        }
    }
}
