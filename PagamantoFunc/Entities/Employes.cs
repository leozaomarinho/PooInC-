using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamantoFunc.Entities
{
    internal class Employes
    {
        public string Name { get; set; }
        public int Hour { get; set; }

        public double ValuePerHour { get; set; }


       
        public Employes() { 
        
        }

        public Employes(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            double pay = ValuePerHour * Hour;

            return pay;

        }
    }
}
