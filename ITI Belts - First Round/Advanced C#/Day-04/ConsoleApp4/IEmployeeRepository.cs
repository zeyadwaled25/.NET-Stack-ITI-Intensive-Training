using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IEmployeeRepository // DIP
    {
        void Save(Employee emp);
    }
}
