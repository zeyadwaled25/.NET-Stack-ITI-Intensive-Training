using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{
    internal class SwitchEventArgs : EventArgs
    {
        public bool IsOn { get; }

        public SwitchEventArgs(bool isOn) 
        {
            IsOn = isOn;
        }
    }
}
