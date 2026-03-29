using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    internal class Tester : Employee
    {
        public double Perks;

        public Tester(int id, string name, double salary) : base(id, name, salary)
        {
            Perks = BasicSalary * 0.30;
        }

        public override double CalculateSalary()
        {
            return BasicSalary + Perks;
        }

        public override void Display()
        {
            base.Display();
            double total = CalculateSalary();

            Console.WriteLine($"Perks: {Perks}");
            Console.WriteLine($"Total Salary: {total}");
            Console.WriteLine($"Annual CTC: {total * 12}\n");
        }
    }
}
