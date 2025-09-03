using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class Magazine
    {
        public string Name;
        public int IssueNumber;

        public override string ToString()
        {
            return $"Magazine Name : {Name}, Issue Number: {IssueNumber}";
        }
    }
}
