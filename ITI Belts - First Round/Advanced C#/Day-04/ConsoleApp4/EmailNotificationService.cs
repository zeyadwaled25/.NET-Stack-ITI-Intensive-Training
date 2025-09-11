using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EmailNotificationService : INotificationService // ISP
    {
        public void SendEmail(Employee emp, string message)
        {
            Console.WriteLine($"Sending email to {emp.Name} with message: {message}");
        }
    }
}
