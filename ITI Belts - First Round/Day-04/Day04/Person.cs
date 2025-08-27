using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Person
    {
        public string name { get; }
        protected int age { get; }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {name}.");
        }
    }
}
