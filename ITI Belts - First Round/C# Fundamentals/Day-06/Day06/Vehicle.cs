using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public abstract void StartEngine();
        
        public abstract void StopEngine();
        public abstract void Drive();
    }
}
