using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class FileLogger : IDisposable
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = new StreamWriter(path, append: true);
        }

        public void LogMessage(string message)
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }

        public void Dispose()
        {
            writer?.Close();
        }
    }
}
