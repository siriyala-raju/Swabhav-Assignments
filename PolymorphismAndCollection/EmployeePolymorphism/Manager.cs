using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace EmployeePolymorphism
{
    internal class Manager : Employee
    {
        public double TA;
        public double DA;

        public Manager(int id, string name, double salary) : base(id, name, salary)
        {
            this.TA = salary * 0.50;
            this.DA = salary * 0.40;
        }

        public override double CalculateSalary()
        {
            double TotalSalary;
            TotalSalary = BasicSalary + TA + DA;
            return TotalSalary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Travel Allowance: {TA}");
            Console.WriteLine($"Dearness Allowance: {DA}");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
            Console.WriteLine($"AnnualCTC: {CalculateSalary() * 12}\n");
        }
    }
}
