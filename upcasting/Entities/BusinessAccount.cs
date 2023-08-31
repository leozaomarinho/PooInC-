using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace upcasting.Entities
{
    internal class BusinessAccount : Account
    {
        public Double LoanLimit { get; set; }

        public BusinessAccount() {
        }
        public BusinessAccount(int number, string holder, double balance, Double loanLimit) 
            : base(number,holder,balance) {
        

        
        }
    }
}
