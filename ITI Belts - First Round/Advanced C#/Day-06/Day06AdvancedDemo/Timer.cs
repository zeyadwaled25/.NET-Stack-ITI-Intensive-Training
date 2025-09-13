using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class Timer
    {
        public event Action Tick;

        public void Start()
        {
            Console.WriteLine("Timer Started ");

            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine($"Tick {i}");

                Tick?.Invoke();
            }
        }
    }
}
