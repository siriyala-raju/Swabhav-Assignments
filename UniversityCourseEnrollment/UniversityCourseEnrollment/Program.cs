namespace UniversityCourseEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Monocept University\n Select Course Type\n 1.Online\n 2.In Person\n 3.Lab");

            int choice = Convert.ToInt32(Console.ReadLine());

            Enrollment enrollment = null;

            switch (choice)
            {
                case 1:
                    enrollment = new Online();
                    break;
                case 2:
                    enrollment = new InPerson();
                    break;
                case 3:
                    enrollment = new Lab();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            
            enrollment.EnrollStudent();
            enrollment.Display();
        }
    }
}
