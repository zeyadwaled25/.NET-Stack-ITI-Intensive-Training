using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void TankFullHandler();
    class WaterTank
    {
        public event TankFullHandler TankFull;

        private int level = 0;
        public void Fill(int amount)
        {
            level += amount;
            if (level >= 100)
            {
                TankFull?.Invoke();
            }
        }
    }
}
