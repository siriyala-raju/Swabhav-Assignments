using System;

namespace PlanetGravityEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Earth weight: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            double earthGravity = Planets.Gravity(Planet.Earth);

            foreach (Planet p in Enum.GetValues(typeof(Planet)))
            {
                if (p == Planet.Earth)
                    continue;

                double planetGravity = Planets.Gravity(p);

                double weight = (earthWeight / earthGravity) * planetGravity;

                Console.WriteLine($"Weight on {p}: {weight:F1} kg");
            }
        }
    }
}
