using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseEnrollment
{
    abstract class Enrollment
    {
        public string CourseName;
        public int StudentCount;

        public abstract void EnrollStudent();

        public virtual void Display()
        {
            Console.WriteLine($"Name of the Course: {CourseName}");
            Console.WriteLine($"Students Enrolled: {StudentCount}");
        }

    }
}
