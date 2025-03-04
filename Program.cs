using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(11, "Saleem", "Textile", 20000.0);
            employee.DisplayDetails();
            employee.IncreaseSalary(10000);
            employee.DisplayDetails();
            //My name is zeenat
        }
    }
}
