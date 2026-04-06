namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 60, 70, 75, 80, 88 };

            Student student1 = new Student("Swapnil Kulkarni", "R102", marks);

            Console.WriteLine(student1);
        }
    }
}
