using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Student
    {
        public string name;
        public int age;

        public Student()
        {
            name = "Unknown";
            age = 0;
        }

        // parameterized constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy constructor
        public Student(Student other)
        {
            name = other.name;
            age = other.age;
        }

        //public void DisplayInfo()
        //{
        //    Console.WriteLine($"Name: {Name}, Age: {Age}");
        //}
    }
}
