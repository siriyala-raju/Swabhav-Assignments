using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConstructorOverloading
{
    internal class BMI
    {
        string name;
        float weight;
        float height;

        public BMI()
        {
            name = "Unknown";
            weight = 0;
            height = 0;
        }

        public BMI(string name)
        {
            this.name = name;
        }

        public BMI(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public BMI(string name, float weight, float height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }
        public void CalculateBMI()
        {
            float bmi = weight / (height * height);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"BMI: {bmi}");
        }
    }
}