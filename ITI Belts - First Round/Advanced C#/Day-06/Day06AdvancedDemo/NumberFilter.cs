using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class NumberFilter
    {
        public event Predicate<int> CheckNumber;

        public void ShowNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (CheckNumber != null && CheckNumber(number))
                    Console.WriteLine("Accepted");
                else
                    Console.WriteLine("Rejected");

            }
        }
    }
}
