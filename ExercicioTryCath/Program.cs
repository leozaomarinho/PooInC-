using System;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                List<Account> accounts = new List<Account>();

                Console.WriteLine("Enter account data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Holder");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                accounts.Add(new Account (number,holder,balance,withdrawLimit));
            }
            catch { }

        }
    }
}