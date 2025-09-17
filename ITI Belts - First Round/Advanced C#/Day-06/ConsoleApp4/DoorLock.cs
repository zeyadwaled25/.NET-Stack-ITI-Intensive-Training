using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class DoorLock
    {
        public event EventHandler<DoorEventArgs> DoorStateChanged;

        public void LockDoor(bool lockIt)
        {
            DoorStateChanged?.Invoke(this, new DoorEventArgs(lockIt));
        }
    }
}
