using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Car : Vehicle
    {
        public int Wheels { get; }

        public Car(string model, int wheels) : base(model)
        {
            Wheels = wheels;
        }

        public void Drive()
        {
            Console.WriteLine($"{Model} driving on {Wheels} wheels");
        }
    }

}
