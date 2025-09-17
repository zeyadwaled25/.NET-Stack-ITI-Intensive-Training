using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class DoorEventArgs : EventArgs
    {
        public bool IsLocked { get; }
        public DoorEventArgs(bool isLocked)
        {
            IsLocked = isLocked;
        }
    }
}
