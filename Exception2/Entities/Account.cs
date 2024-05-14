using System.Globalization;

class Account{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account(int number, string holder, double balance, double withdrawLimit){
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void Deposit(double value){
        Balance += value;
        System.Console.WriteLine("New balance: " + Balance);
    }

    public void Withdraw(double value){
        if(Balance <= 0 || Balance <= value){
            throw new DomainException("Insufficient account balance");
        }
        if(value > WithdrawLimit){
            throw new DomainException("The amount exceeds the withdrawal limit");
        }
        Balance -= value;
        System.Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
    }
}