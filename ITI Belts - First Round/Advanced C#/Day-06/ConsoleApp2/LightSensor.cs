using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void LightChangedHandler(int luxLevel);
    class LightSensor
    {
        public event LightChangedHandler LightChanged;

        public void SetLightLevel(int level)
        {
            LightChanged?.Invoke(level);
        }
    }
}
