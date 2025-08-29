using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Engine
    {
        public virtual void Start()
        {
            Console.WriteLine("Engine Started");
        }
        


    }


    public class CarEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Car Engine Started");
        }
    }

}
