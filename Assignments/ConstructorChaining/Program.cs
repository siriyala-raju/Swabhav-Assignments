namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMI p1 = new BMI("Raju", 70, 1.75f);
            p1.CalculateBMI();
        }
    }
}
