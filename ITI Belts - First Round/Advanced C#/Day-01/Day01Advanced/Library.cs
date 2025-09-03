using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class Library<T>
    {
        private T[] items;
        private int index = 0;

        public Library(int size)
        {
            items = new T[size];
        }

        public void Add(T item)
        {
            if (index < items.Length)
            {
                items[index] = item;
                index++;
            }
        }


        public void ShowAll()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
