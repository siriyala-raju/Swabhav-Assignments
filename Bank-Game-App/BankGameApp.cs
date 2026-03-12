using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Game_App
{
    internal class BankGameApp
    {
        public string AccountHolder;
        public double Balance;

        public BankGameApp(string name, double balance)
        {
            AccountHolder = name;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine(AccountHolder + " Balance: " + Balance);
        }
    }
}
