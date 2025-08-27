using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
