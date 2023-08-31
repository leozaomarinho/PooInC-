using System;
using System.Collections.Generic;
using System.Globalization;
using PagamantoFunc.Entities;


namespace Pagamento
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Employes> list = new List<Employes>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employe number #{i} data:");
                Console.Write("OutSourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmploye(name,hours,valuePerHour,additionalCharge));
                }
                else
                {
                    list.Add(new Employes(name,hours,valuePerHour));
                }
                Console.WriteLine("--------------------------------------------------");
            }
            
            Console.WriteLine("Payments: ");
            Console.WriteLine("--------------------------------------------------");

            foreach (Employes employes in list)
            {
                
                    Console.WriteLine($"{employes.Name} - $ {employes.Payment().ToString("F2",CultureInfo.InvariantCulture)}");
                
            }





        }
    }
}