using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace StudentGrading
{
    internal class Student
    {
        public string Name { get; set; }
        public string RollNo { get; set; }
        public int[] Marks { get; set; }

        public Student(string name, string rollNo, int[] marks)
        {
            this.Name = name;
            this.RollNo = rollNo;
            this.Marks = marks;
        }

        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int score in Marks)
            {
                sum += score;
            }
            double average = sum / 5.0;
            return average;
        }

        public string CalculateGrade()
        {
            double average = CalculateAverage();
            if (average >= 90)
                return "A+";
            else if (average >= 80)
                return "A";
            else if (average >= 70)
                return "B";
            else if (average >= 60)
                return "C";
            else if (average >= 50)
                return "D";
            else
                return "Fail";
        }
        public override string ToString()
        {
            string marksList = "[";

            for (int i = 0; i < Marks.Length; i++)
            {
                marksList += Marks[i];

                if (i < Marks.Length - 1)
                    marksList += ", ";
            }

            marksList += "]";

            return $"Student Report Card\n" +
                   $"----------------------------\n" +
                   $"Name        : {Name}\n" +
                   $"Roll No     : {RollNo}\n" +
                   $"Marks       : {marksList}\n" +
                   $"Average     : {CalculateAverage():0.0}\n" +
                   $"Grade       : {CalculateGrade()}";
        }
    }
}
