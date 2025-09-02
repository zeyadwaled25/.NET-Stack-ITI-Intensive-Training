using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class SportsCar : Car
    {
        public bool HasTurbo { get; }

        public SportsCar(string model, int wheels, bool hasTurbo) : base(model, wheels)
        {
      
            HasTurbo = hasTurbo;
        }

        public void Boost()
        {
            if (HasTurbo)
                Console.WriteLine($"{Model} activates turbo!");
            else
                Console.WriteLine($"{Model} has no turbo.");
        }
    }
}
