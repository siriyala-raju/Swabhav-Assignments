namespace PredicateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Amit", Marks = 75, Age = 19 },
                new Student { Name = "Anita", Marks = 80, Age = 20 },
                new Student { Name = "Ravi", Marks = 45, Age = 17 },
                new Student { Name = "Arjun", Marks = 90, Age = 16 },
                new Student { Name = "Pooja", Marks = 55, Age = 21 },
                new Student { Name = "Kiran", Marks = 40, Age = 22 }
            };

            Predicate<Student> highMarks = s => s.Marks > 60;
            Predicate<Student> youngAge = s => s.Age < 18;
            Predicate<Student> startsWithA = s => s.Name.StartsWith("A");

            List<Student> highMarkStudents = students.FindAll(highMarks);
            List<Student> youngStudents = students.FindAll(youngAge);
            List<Student> aStudents = students.FindAll(startsWithA);

            Console.Write("Students with Marks > 60: ");
            foreach (Student s in highMarkStudents)
                Console.Write(s.Name + " ");

            Console.Write("\nStudents Age < 18: ");
            foreach (Student s in youngStudents)
                Console.Write(s.Name + " ");

            Console.Write("\nNames starting with A: ");
            foreach (Student s in aStudents)
                Console.Write(s.Name + " ");

            Console.WriteLine("\n\nExists Check:");
            Console.WriteLine("Any student marks > 60: " + students.Exists(highMarks));
            Console.WriteLine("Any student age < 18: " + students.Exists(youngAge));
            Console.WriteLine("Any name starts with A: " + students.Exists(startsWithA));
        }
    }
}
