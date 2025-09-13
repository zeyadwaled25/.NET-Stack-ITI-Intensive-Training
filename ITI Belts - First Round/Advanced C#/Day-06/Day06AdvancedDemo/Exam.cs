using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class Exam
    {
        public event Func<int, int, int, double> CalculateAverage;

        public void ShowAverage(int math, int science, int english)
        {
          
                if (CalculateAverage != null)
                {
                    double avg = CalculateAverage(math, science, english);

                      Console.WriteLine($"Average grade = {avg}");
                }
                else                
                    Console.WriteLine("No calculation provided");

        }
            
    }
}
