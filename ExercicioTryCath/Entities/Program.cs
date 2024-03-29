﻿using System.Globalization;
using System;

using ExercicioTryCath.Entities;
using ExercicioTryCath.Entities.Exceptions;

namespace ExercicioTryCath.Entities
{
    public class Program
    {
        static void Main(string[] args)
        {



            List<Account> accounts = new List<Account>();

            Console.WriteLine("Enter account data");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Holder");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw:");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);


            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}