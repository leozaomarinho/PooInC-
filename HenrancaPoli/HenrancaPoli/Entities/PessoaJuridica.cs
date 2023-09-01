using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrancaPoli.Entities
{
    public class PessoaJuridica : Contribuintes
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string name,double anualIncome , int numberOfEmpl) 
            : base(name,anualIncome) {
        
        }

        public override double Tax()
        {
            
        }



    }
}
