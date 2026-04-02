using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCastDelegate
{
    internal class Communicate
    {
        public delegate void Notify(string message);

        public static void SendEmail(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine("SMS Sent: " + message);
        }

        public static void SendWhatsApp(string message)
        {
            Console.WriteLine("WhatsApp Sent: " + message);
        }
    }
}
