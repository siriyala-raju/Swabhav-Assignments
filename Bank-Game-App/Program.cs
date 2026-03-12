namespace Bank_Game_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            BankGameApp acc1 = new BankGameApp("Account1", r.Next(2000, 5000));
            BankGameApp acc2 = new BankGameApp("Account2", r.Next(2000, 5000));

            Console.WriteLine("Starting Balances");
            acc1.ShowBalance();
            acc2.ShowBalance();
            Console.WriteLine();

            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine("Round " + round);

                Console.Write("Account1 Withdraw or Deposit (w/d): ");
                char choice1 = Convert.ToChar(Console.ReadLine());

                if (choice1 == 'w' || choice1 == 'W')
                {
                    Console.Write("Amount to Withdraw: ");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    acc1.Withdraw(amt);
                }
                else
                {
                    Console.Write("Amount to Deposit: ");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    acc1.Deposit(amt);
                }

                Console.Write("Account2 Withdraw or Deposit (w/d): ");
                char choice2 = Convert.ToChar(Console.ReadLine());

                if (choice2 == 'w' || choice2 == 'W')
                {
                    Console.Write("Amount to Withdraw: ");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    acc2.Withdraw(amt);
                }
                else
                {
                    Console.Write("Amount to Deposit: ");
                    double amt = Convert.ToDouble(Console.ReadLine());
                    acc2.Deposit(amt);
                }

                Console.WriteLine("\nBalances after Round " + round);
                acc1.ShowBalance();
                acc2.ShowBalance();
                Console.WriteLine();
            }

            Console.WriteLine("Final Result");

            if (acc1.Balance > acc2.Balance)
                Console.WriteLine("Winner: " + acc1.AccountHolder);
            else if (acc2.Balance > acc1.Balance)
                Console.WriteLine("Winner: " + acc2.AccountHolder);
            else
                Console.WriteLine("It's a Tie!");
        }
    }
}
