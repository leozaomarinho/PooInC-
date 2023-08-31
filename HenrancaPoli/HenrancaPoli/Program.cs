using HenrancaPoli.Entities;
using System;
using System.Globalization;

namespace HenrancaPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c) ? ");
                char ch = char.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual income: ");
                    double anualInc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(name, anualInc, healthExp));
                }

            }

        }
    }
}