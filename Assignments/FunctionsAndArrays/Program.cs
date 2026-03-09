namespace FunctionsAndArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] fees = new double[5];
            Discount obj = new Discount();

            for (int i = 0; i < fees.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter fees for Student {i + 1} : ");
                    double fee = Convert.ToDouble(Console.ReadLine());

                    if (fee < 5000 || fee > 10000)
                    {
                        Console.WriteLine("Fees must be in the range 5000 to 10000");
                    }
                    else
                    {
                        fees[i] = fee;
                        break;
                    }
                }
            }
            for (int i = 0; i < fees.Length; i++)
            {
                double finalFee = obj.CalculateDiscount(fees[i]);
                Console.WriteLine($"Student {i + 1} : {finalFee}");
            }
            Console.ReadLine();
        }
    }
}
