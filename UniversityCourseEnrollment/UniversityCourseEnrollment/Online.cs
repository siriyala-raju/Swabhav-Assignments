using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseEnrollment
{
    class Online : Enrollment
    {
        public string PlatformLink;

        public override void EnrollStudent()
        {
            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            Console.Write("Enter Student Count: ");
            StudentCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Video Platform Link: ");
            PlatformLink = Console.ReadLine();

            if (string.IsNullOrEmpty(PlatformLink))
            {
                Console.WriteLine("Platform Link must be required");
            }
            else
            {
                Console.WriteLine("Successfully Enrolled for Online Course\n\n");
            }
        }

        public override void Display()
        {
            Console.WriteLine("-----Course Enrollment Details-----");
            Console.WriteLine("Enrolled Course Type: Online");
            Console.WriteLine($"Enrolled Course Name: {CourseName}");
            Console.WriteLine($"Total Students Enrolled: {StudentCount}");
            Console.WriteLine($"Video Platform Link: {PlatformLink}");
        }
    }
}
