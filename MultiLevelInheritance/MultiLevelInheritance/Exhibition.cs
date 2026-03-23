using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevelInheritance
{
    internal class Exhibition : Banquet
    {
            int TotalStalls;
            int StallRent;

            public Exhibition(int id, string name, int capacity, int stalls, int rent) : base(id, name, capacity)
            {
                if (stalls > capacity / 2)
                {
                    Console.WriteLine("Stalls cannot exceed half of capacity");
                    stalls = capacity / 2; // adjust to safe value
                }

                TotalStalls = stalls;
                StallRent = rent;
            }

            public override int CalculateEarning()
            {
                return (TotalStalls * StallRent);
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Total Stalls: {TotalStalls}");
                Console.WriteLine($"Stall Rent: {StallRent}");
                Console.WriteLine($"Total Earnings: {CalculateEarning()}");
            }
    }
}

