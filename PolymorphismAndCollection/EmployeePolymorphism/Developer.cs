using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    internal class Developer : Employee
    {
        public double PA;

        public Developer(int id, string name, double salary) : base (id, name, salary)
        {
            this.PA = salary * 0.40;
        }

        public override double CalculateSalary()
        {
            double TotalSalary = BasicSalary + PA;
            return TotalSalary;
        }

        public override void Display()
        {
            base.Display();
            double total = CalculateSalary();
            Console.WriteLine($"Project Allowance Amount: {PA}");
            Console.WriteLine($"Total Salary: {total}");
            Console.WriteLine($"AnnualCTC: {total * 12}\n");
        }
    }
}
