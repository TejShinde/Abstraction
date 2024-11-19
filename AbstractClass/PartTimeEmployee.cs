using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class PartTimeEmployee : Employee1
    {
        public PartTimeEmployee(string name, int id, int hoursWorked) : base(name, id, hoursWorked)
        {

        }
        public override double CalculateSalary()
        {
            return hoursWorked * 200;
        }
    }
}
