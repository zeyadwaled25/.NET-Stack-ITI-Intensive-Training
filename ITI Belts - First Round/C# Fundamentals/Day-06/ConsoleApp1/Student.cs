using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public string major { get; set; } // Auto-property
        public double gpa { get; set; } // Auto-property

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Student Name: {FullName}, Student Age: {Age}");
            Console.WriteLine($"Student Major: {major}, Student Gpa: {gpa}");
        }

        //method overloading
        public void RegisterCourse(string courseName)
        {
            Console.WriteLine($"{FullName} has registered for the course: {courseName}");
        }
        public void RegisterCourse(string courseName, int credits)
        {
            Console.WriteLine($"{FullName} has registered for the course: {courseName} with {credits} credits");
        }
    }
}
