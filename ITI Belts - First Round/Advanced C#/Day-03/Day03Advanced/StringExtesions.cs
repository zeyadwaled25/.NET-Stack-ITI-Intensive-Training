using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03Advanced
{
    internal static class StringExtesions
    {
        public static bool checkIfFirstUppercase(this string str)
        {
            if(string.IsNullOrEmpty(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}
