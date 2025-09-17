using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Order
    {
        public event EventHandler OrderPlaced;

        public void PlaceOrder()
        {
            OrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}
