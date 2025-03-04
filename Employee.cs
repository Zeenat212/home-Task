using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_2_
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int id,string name,string department,double salary)
        {
            EmployeeID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details are : ");
            Console.WriteLine($"Employee ID is {EmployeeID}");
            Console.WriteLine($"Employee Name is {Name}");
            Console.WriteLine($"Employee Department is {Department}");
            Console.WriteLine($"Employee Salary is {Salary}");
        }
      public void IncreaseSalary(double amount)
        {
           if(amount > 0)
            {
                Salary += amount;
                Console.WriteLine($"Salary increased is {Salary}");
            }
            else
            {
                Console.WriteLine("Invalid Salary Increases Amount");
            }
        }
    }
}
