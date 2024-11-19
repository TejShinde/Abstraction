using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Employee1
    {
        protected string name;
        protected int id;
        protected int hoursWorked;

        public Employee1(string name,int id,int hoursWorked)
        {
            this.name = name;
            this.id = id;
            this.hoursWorked = hoursWorked;
        }

        public virtual double CalculateSalary()
        {
            return 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Id: {id},Hours Worked: {hoursWorked},Salary: {CalculateSalary()}");
        }

       
    }
}
