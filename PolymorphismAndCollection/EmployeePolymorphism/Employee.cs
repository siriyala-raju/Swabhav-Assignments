using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    internal class Employee
    {
        public int EmpId;
        public string EmpName;
        public double BasicSalary;

        public Employee(int id, String name, double salary)
        {
            this.EmpId = id;
            this.EmpName = name;
            this.BasicSalary = salary;
        }

        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee Id: {EmpId}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee Salary: {BasicSalary}\n");
        }
    }
}
