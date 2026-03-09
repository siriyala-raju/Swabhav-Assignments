namespace ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMI p1 = new BMI("Rahul", 70, 1.75f);
            p1.CalculateBMI();
        }
    }
}
