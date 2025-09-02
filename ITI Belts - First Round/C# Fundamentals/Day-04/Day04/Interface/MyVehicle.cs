using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Interface
{
    public class MyVehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }
    }
}
