class Account
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

            Console.WriteLine("Deposito realizado, saldo atualizado!");
        }
        else {
            throw new Exception("O valor do deposito não pode ser menor ou igual a zero!");
        
        }

    }

    public void Withdraw(double amount)
    {

    }
}