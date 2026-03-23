using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevelInheritance
{
    internal class Banquet
    {
        public int BanquetId;
        public string BanquetName;
        public int Capacity;

        public Banquet(int id, string name, int capacity)
        {
            BanquetId = id;
            BanquetName = name;
            Capacity = capacity;
        }

        public virtual int CalculateEarning()
        {
            return Capacity * 100;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Banquet Id: {BanquetId}");
            Console.WriteLine($"Banquet Name: {BanquetName}");
            Console.WriteLine($"Capacity: {Capacity}");
        }
    }
}
