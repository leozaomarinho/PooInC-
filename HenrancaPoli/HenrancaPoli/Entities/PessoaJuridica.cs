using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrancaPoli.Entities
{
     class PessoaJuridica : Contribuintes
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string name,double anualIncome , int numberOfEmpl) 
            : base(name,anualIncome) {
        
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                double imp = AnualIncome * 0.14;
                return imp;
            }
            else
            {
                double imp = AnualIncome * 0.16;
                return imp;
            }
        }



    }
}
