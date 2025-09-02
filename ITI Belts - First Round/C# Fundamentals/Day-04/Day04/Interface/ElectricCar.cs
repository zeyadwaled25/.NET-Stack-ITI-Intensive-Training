using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Interface
{
    public class ElectricCar : MyVehicle, IChargeable, IMaintainble
    {
        public void Charge()
        {
            Console.WriteLine($"{Brand} is charging");
        }

        public void Maintain()
        {
            Console.WriteLine($"{Brand} is maintaining ");
        }
    }
}
