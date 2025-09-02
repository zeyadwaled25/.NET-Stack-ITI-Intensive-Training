using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Sealed_Class
{
    public sealed class FinalReport
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public FinalReport(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void PrintReport()
        {
            Console.WriteLine($"=== {Title} ===");
            Console.WriteLine(Content);
        }
    }
}
