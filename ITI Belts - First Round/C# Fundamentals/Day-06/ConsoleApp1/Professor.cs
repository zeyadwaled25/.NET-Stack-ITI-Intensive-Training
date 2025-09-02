using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Professor : Person, ITeacher
    {
        public string department { get; set; } // Auto-property
        public double salary { get; set; } // Auto-property

        public override void DisplayInfo()
        {
            Console.WriteLine($"Professor ID: {Id}, Professor Name: {FullName}, Professor Age: {Age}");
            Console.WriteLine($"Professor Department: {department}, Professor Salary: {salary}");
        }

        //Professor implement this interface
        public void TeachCourse(string courseName)
        {
            Console.WriteLine($"{FullName} is teaching the course: {courseName}");
        }
    }
}
