using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevelInheritance
{
    internal class Event : Banquet
    {
        int TotalPax;

        public Event(int id, string name, int capacity, int pax) : base(id, name, capacity)
        {
            if (pax > capacity)
            {
                Console.WriteLine("Total Pax cannot exceed Capacity");
                pax = capacity; // adjust to safe value
            }

            TotalPax = pax;
        }

        public override int CalculateEarning()
        {
            int basicEarning = base.CalculateEarning();
            return TotalPax * basicEarning;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Total Pax: {TotalPax}");
            Console.WriteLine($"Total Earnings: {CalculateEarning()}");
        }
    }
}
