using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrancaPoli.Entities
{
    abstract class Contribuintes
        //se o metodo for abstrato, a classe obrigatoriamente deve ser
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contribuintes() { 
        
        }

        public Contribuintes(string name, double anualIncome)
        {
            this.Name = name;
            this.AnualIncome = anualIncome;
        }

        public abstract double Tax();
        //metodos abstratos são criados sem argumentos, pois o abstract sinaliza que o metodo será implementando em outra classe que herde
       //com o abstract não precisa do virtual para fazer o override do metodo
    }
}
