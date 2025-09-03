using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class Book
    {
        public string Title;
        public string Author;

        public override string ToString()
        {
            return $"Title: {Title} by Author: {Author}";
        }
    }
}
