using System;
using System.Globalization;
using ExercicioTryCath.Entities;
using ExercicioTryCath.Entities.Exceptions;


public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account()
    {

    }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        this.Number = number;
        this.Holder = holder;
        this.Balance = balance;
        this.WithdrawLimit = withdrawLimit;

    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;

            Console.WriteLine($"Deposito realizado, saldo atualizado R${Balance}");
        }
        else {
            throw new  ("O valor do deposito n�o pode ser menor ou igual a zero!");
        
        }

    }

    public void Withdraw(double amount)
    {
        if (amount > WithdrawLimit)
        {
            throw new  ("O valor do saque n�o pode exceder o limite de saque!");

        }
        if (amount > Balance)
        {
            throw new DomainException("Not enough balace!");
        }
        else
        {

            Balance -= amount;

            Console.WriteLine($"Saque no valor de ${amount.ToString("F2",CultureInfo.InvariantCulture)}, Realizado com sucesso!");
            Console.WriteLine($"saldo atualizado ${Balance.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
 