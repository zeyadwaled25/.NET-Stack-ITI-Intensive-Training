using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ManagerBonusCalculator : IBonusCalculator // OCP
    {
        public double CalculateBonus(Employee emp) => emp.Salary * 0.2;
    }
    public class DeveloperBonusCalculator : IBonusCalculator // OCP
    {
        public double CalculateBonus(Employee emp) => emp.Salary * 0.1;
    }
    public class DefaultBonusCalculator : IBonusCalculator // OCP
    {
        public double CalculateBonus(Employee emp) => 0;
    }
}
