using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndArrays
{
    internal class Discount
    {
        public double CalculateDiscount(double fee)
        {
            if (fee > 7000)
            {
                fee = fee - (fee * 0.05);
            }
            return fee;
        }
    }
}
