using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseEnrollment
{
    internal class InPerson : Enrollment
    {
        public int RoomNumber;
        public int ValidCapacity;

        public override void EnrollStudent()
        {
            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            Console.Write("Enter Student Count: ");
            StudentCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Room Number: ");
            RoomNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Room Capacity: ");
            ValidCapacity = Convert.ToInt32(Console.ReadLine());

            if (StudentCount > ValidCapacity)
            {
                Console.WriteLine("No Room Available, fully Occupied");
            }
            else
            {
                Console.WriteLine("Successfully Enrolled for In Person Course\n\n");
            }
        }

        public override void Display()
        {
            Console.WriteLine("-----Course Enrollment Details-----");
            Console.WriteLine("Enrolled Course Type: In Person");
            Console.WriteLine($"Enrolled Course Name: {CourseName}");
            Console.WriteLine($"Total Students Enrolled: {StudentCount}");

            if (StudentCount > ValidCapacity)
            {
                Console.WriteLine("Room Status: Not Alloted");
            }
            else
            {
                Console.WriteLine($"Alloted Room Number: {RoomNumber}");
            }
        }
    }
}
