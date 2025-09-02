using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }
}
