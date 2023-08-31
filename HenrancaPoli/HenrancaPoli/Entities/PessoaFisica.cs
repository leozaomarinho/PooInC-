using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrancaPoli.Entities
{
    internal class PessoaFisica : Contribuintes
    {

        public double HealthExpenditures { get; set; }

        public PessoaFisica(string name,double anualIncome,double healthExp)
        :base(name,anualIncome){ 
        
            this.HealthExpenditures = healthExp;

        }

        public override double Tax()
        {
            if (AnualIncome < 20000 && AnualIncome>0)
            {
                if (HealthExpenditures > 0)
                {
                    double desc = HealthExpenditures * 0.5;

                    double imp = AnualIncome * 0.15;

                    imp -= desc;

                    return imp;
                }
                else
                {
                    double imp = AnualIncome * 0.15;

                    return imp;
                }

            }
            else if (AnualIncome >= 20000)
            {
                if (HealthExpenditures > 0)
                {
                    double desc = HealthExpenditures * 0.5;

                    double imp = AnualIncome * 0.25;

                    imp -= desc;

                    return imp;
                }
                else {
                    double imp = AnualIncome * 0.25;

                    return imp;
                };

            }
            else
            {
                return 0;
            };
        }


    }
}
