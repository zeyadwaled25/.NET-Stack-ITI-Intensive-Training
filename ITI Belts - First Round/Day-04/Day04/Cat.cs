using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }

}
