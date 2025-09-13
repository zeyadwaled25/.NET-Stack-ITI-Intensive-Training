using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class Alarm
    {
        public event AlaramHandler AlarmRang;

        public void Ring()
        {
            Console.WriteLine("Alarm is ringing");
            if(AlarmRang != null)
            {
                AlarmRang();
            }   
        }
    }
}
