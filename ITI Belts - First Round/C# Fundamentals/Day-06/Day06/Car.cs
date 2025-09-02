using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model, int year) : base(brand, model, year)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"{Brand} is driving");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} engine stared");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Brand} engine Stoped");

        }
    }
}
