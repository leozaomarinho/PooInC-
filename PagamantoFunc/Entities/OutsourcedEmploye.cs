using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamantoFunc.Entities
{
    internal class OutsourcedEmploye : Employes
    {
        double AdditionalCharge;

        public OutsourcedEmploye() { 
        
        }

        public OutsourcedEmploye(string name, int hour, double valuePerHour,double additionalCharge)
            :base(name,hour,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }


    
}
