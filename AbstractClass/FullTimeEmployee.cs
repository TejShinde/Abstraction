using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class FullTimeEmployee : Employee1
    {
        public FullTimeEmployee(String name,int id,int hoursWorked) : base(name,id, hoursWorked)
        { 
        }
        public override double CalculateSalary()
        {
            return hoursWorked*500;
        }
    }
}
