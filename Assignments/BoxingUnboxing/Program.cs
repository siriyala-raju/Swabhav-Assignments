namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5553;
            object obj = num;
            Console.WriteLine($"After Boxing Value stored in the object: {obj}");

            int num2 = (int)obj;
            Console.WriteLine($"After Unboxing Value stored in int: {num2}");
        }
    }
}
