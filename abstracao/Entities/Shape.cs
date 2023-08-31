using abstracao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracao.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape() {
        
        }

        public Shape(Color Color) { }
        public abstract double Area(); 
        //o abstract já sinaliza que o metodo vai ter que ser implementado em outra classe que herde
    }
}
