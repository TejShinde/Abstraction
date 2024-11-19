using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Employee1Main
    {
        static void Main(string[] args)
        {
            Employee1 e = new PartTimeEmployee("Tej",1,20);
            e.DisplayInfo();

            Employee1 e2 = new FullTimeEmployee("Mira",2,30);
            e2.DisplayInfo();
        }
    }
}
