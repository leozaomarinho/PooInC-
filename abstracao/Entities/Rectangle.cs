using abstracao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao.Entities
{
    internal class Rectangle : Shape
    {
        //
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }

        public Rectangle(double width,double height,Enum.Color color)
        : base(color)
        {
        
            Width = width;
            Height = height;
           

        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
