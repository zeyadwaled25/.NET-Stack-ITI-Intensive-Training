using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Vehicle
    {
        public string Model { get; }

        public Vehicle(string model)
        {
            Model = model;
        }

        public void Start()
        {
            Console.WriteLine($"{Model} engine started");
        }
    }
}
