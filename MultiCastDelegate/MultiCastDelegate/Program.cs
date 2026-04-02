using static MultiCastDelegate.Communicate;

namespace MultiCastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notify notify = null;
            notify += SendEmail;
            notify += SendSMS;
            notify += SendWhatsApp;

            notify("Order Placed");

            Console.WriteLine("\n---- After Removing SMS ----\n");

            notify -= SendSMS;

            notify("Order Shipped");
        }
    }
}
