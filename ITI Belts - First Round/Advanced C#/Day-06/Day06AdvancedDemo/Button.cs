using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06AdvancedDemo
{

    internal class Button
    {
        public event EventHandler Clicked;

        public void Click()
        {
            Console.WriteLine("Button Clicked!");
            if(Clicked != null) Clicked(this, EventArgs.Empty);
        }
    }
}
