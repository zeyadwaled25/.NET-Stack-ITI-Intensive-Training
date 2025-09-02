using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day04
{
    public class Dog : Animal
    {
      
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
}
