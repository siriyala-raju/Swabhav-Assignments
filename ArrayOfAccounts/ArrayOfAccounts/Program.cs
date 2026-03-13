namespace ArrayOfAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of accounts: ");
            int n = int.Parse(Console.ReadLine());

            Account[] acc = new Account[n];
            int count = 0;
            Random r = new Random();

            while (true)
            {
                Console.WriteLine("\n1.Create 2.View 3.Deposit 4.Withdraw 5.Exit");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Balance: ");
                    double bal = double.Parse(Console.ReadLine());

                    Console.Write("Type: ");
                    string type = Console.ReadLine();

                    string accNo = "IDBI1000" + r.Next(10000, 99999);

                    acc[count] = new Account(accNo, name, bal, type);
                    Console.WriteLine("Account created: " + accNo);

                    count++;
                }

                else if (ch == 2)
                {
                    Console.Write("Account No: ");
                    string a = Console.ReadLine();

                    for (int i = 0; i < count; i++)
                        if (acc[i].accNo == a)
                            Console.WriteLine("Balance: " + acc[i].balance);
                }

                else if (ch == 3)
                {
                    Console.Write("Account No: ");
                    string a = Console.ReadLine();

                    Console.Write("Amount: ");
                    double amt = double.Parse(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                        if (acc[i].accNo == a)
                            acc[i].deposit(amt);
                }

                else if (ch == 4)
                {
                    Console.Write("Account No: ");
                    string a = Console.ReadLine();

                    Console.Write("Amount: ");
                    double amt = double.Parse(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                        if (acc[i].accNo == a)
                            acc[i].withdraw(amt);
                }

                else if (ch == 5)
                    break;
            }
        }
    }
}
