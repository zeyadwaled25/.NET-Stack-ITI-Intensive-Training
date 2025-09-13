using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class EmergencyButton
    {
        public event EmergencyHandler ButtonPressed;

        public void Press(String level)
        {
            Console.WriteLine("Emergency button pressed with level: " + level);
            if (ButtonPressed != null)
            {
                ButtonPressed(level);
            }
        }
    }
}
