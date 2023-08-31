using System;
using upcasting.Entities;

namespace upcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001,"Alex", 0.0);

            BusinessAccount bAcc = new BusinessAccount(1002,"Maria", 15,500.0);

            //UPCASTING
            Account acc1 = bAcc;
            //a variavel do tipo account ela recebe naturalmente um objeto de qualquer subclasse dela, isso é chamado de upcasting
            Account acc2 =  new BusinessAccount(1003,"Bob",0.0,200.0);
            //pode criar uma subclasse e atribuir a instanciação para a superclasse.
            Account acc3 = new SavingsAccount(1004,"Anna",15,0.1);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc1.WithDraw(10);

            acc3.WithDraw(8);

            Console.WriteLine(acc1.Balance);

            Console.WriteLine(acc3.Balance);

        }
    }
}