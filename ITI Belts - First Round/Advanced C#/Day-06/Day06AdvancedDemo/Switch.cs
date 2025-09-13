using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class Switch
    {
        public event EventHandler<SwitchEventArgs> TurnedOn;

        public void TurnOn()
        {
            Console.WriteLine("Switch turned on ");

            TurnedOn?.Invoke(this, new SwitchEventArgs(true));
        }
    }
}
