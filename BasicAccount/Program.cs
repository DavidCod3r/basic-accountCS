using System;

namespace BasicAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter account holder: ");
            string holder = Console.ReadLine();
            Console.Write("Is there an initial deposit? (y/n): ");
            char ch = char.Parse(Console.ReadLine());
            if(ch == 'y')
            {
                Console.Write("Enter initial deposit value: ");
                double initialDeposit = double.Parse(Console.ReadLine());

                account = new Account(number, holder, initialDeposit);
            }
            else
            {
                account = new Account(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account data: ");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Enter a deposit value: ");
            account.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Updated data: ");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Enter a withdraw value: ");
            account.WithDraw(double.Parse(Console.ReadLine()));
            Console.WriteLine("Updated data: ");
            Console.WriteLine(account);
            Console.WriteLine();
        }
    }
}
