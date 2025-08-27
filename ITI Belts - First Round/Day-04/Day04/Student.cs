using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Student : Person
    {

        public string Major { get; }

        public Student(string name, int age, string major) : base(name, age)
        {

            Major = major;
        }

        public void Study()
        {
            Console.WriteLine($"{name} studies {Major} and is {age} years old.");
        }
    }
}
