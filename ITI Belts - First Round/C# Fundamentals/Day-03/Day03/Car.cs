using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Car
    {
        // Automatic properties
        public string Brand { get; set; }
        public int ModelYear { get; set; }



        public Car(string Brand, int ModelYear)
        {
            this.Brand = Brand;
            this.ModelYear = ModelYear;
        }


    }
}
