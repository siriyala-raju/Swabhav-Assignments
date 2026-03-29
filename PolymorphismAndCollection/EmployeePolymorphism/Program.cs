namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nSelect Employee Type:");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Developer");
                Console.WriteLine("3. Tester");

                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine($"Employee: {i+1}");

                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                double salary = double.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    employees[i] = new Manager(id, name, salary);
                }
                else if (choice == 2)
                {
                    employees[i] = new Developer(id, name, salary);
                }
                else if (choice == 3)
                {
                    employees[i] = new Tester(id, name, salary);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            Console.WriteLine("----- Employee Details -----");

            foreach (Employee emp in employees)
            {
                emp.Display();
            }
        }
    }
}
