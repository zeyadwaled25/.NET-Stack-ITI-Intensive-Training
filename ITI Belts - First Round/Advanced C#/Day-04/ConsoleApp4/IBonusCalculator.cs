using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IBonusCalculator // OCP
    {
        double CalculateBonus(Employee emp);
    }
}
