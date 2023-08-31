using abstracao.Entities;
using abstracao.Entities.Enum;
using System;
using System.Globalization;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //se uma classe possuir pelo menos um método abstrato, então esta classe também é abstrata

            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or circle? (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red) ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {

                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                }
                else if (ch == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }
                else {
                    Console.WriteLine("Opção invalida!");
                }


            }

            Console.WriteLine("SHAPRE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area().ToString("F2")}");
            }

        }
    }
}