using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UniversityCourseEnrollment
{
    internal class Lab : Enrollment
    {
        public Boolean TrainingCompleted;

        public override void EnrollStudent()
        {
            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            Console.Write("Enter Student Count: ");
            StudentCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Safety Training Completed (true/false): ");
            TrainingCompleted = Convert.ToBoolean(Console.ReadLine());

            if (!TrainingCompleted)
            {
                Console.WriteLine("Safety Training Required");
            }
            else
            {
                Console.WriteLine("Successfully Enrolled for Lab Course\n\n");
            }
        }

        public override void Display()
        {
            Console.WriteLine("-----Course Enrollment Details-----");
            Console.WriteLine("Enrolled Course Type: Lab");
            Console.WriteLine($"Enrolled Course Name: {CourseName}");
            Console.WriteLine($"Total Students Enrolled: {StudentCount}");

            if (TrainingCompleted)
            {
                Console.WriteLine("Safety Training: Completed");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
