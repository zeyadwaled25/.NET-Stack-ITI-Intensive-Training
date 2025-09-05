using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Box<T>
    {
        public T Item { get; set; }

        public Box(T item)
        {
            Item = item;
        }

        public void ShowInfo()
        {
            dynamic? dynamicItem = Item;
            Console.WriteLine($"Item Info: Name = {dynamicItem?.Name}, Price = {dynamicItem?.Price}");
        }
    }
}
