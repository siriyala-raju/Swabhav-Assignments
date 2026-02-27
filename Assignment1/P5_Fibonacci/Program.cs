namespace P5_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.Write("Enter a Number: ");
            //int input = int.Parse(Console.ReadLine());
            //In problem statement you mentioned 8 thats why direclty I took 8 as count. If user input it will be count = input
            int count = 8;
            int first = 0;
            int second = 1;

            Console.Write($"Fibonaci Series of {count} is {first} {second} ");

            for (int i = 3; i <= count; i++)
            {
                int next = first + second;
                Console.Write($"{next} ");

                first = second;
                second = next;
            }
        }
    }
}
