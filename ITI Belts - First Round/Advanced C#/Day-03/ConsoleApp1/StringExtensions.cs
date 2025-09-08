using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringExtensions
    {
        public static string ReverseText(this string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return new string(text.Reverse().ToArray());
        }

        public static int CountCharacters(this string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            return text.Length;
        }
    }
}
