using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOfAccounts
{
    internal class Account
    {
        public string accNo, name, type;
        public double balance;

        public Account(string a, string n, double b, string t)
        {
            accNo = a;
            name = n;
            balance = b;
            type = t;
        }

        public void deposit(double amt)
        {
            balance += amt;
        }

        public void withdraw(double amt)
        {
            if (balance - amt >= 500)
                balance -= amt;
            else
                Console.WriteLine("Minimum balance 500 required");
        }
    }
}
