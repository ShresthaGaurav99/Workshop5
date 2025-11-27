public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber => accountNumber;

    public double Balance
    {
        get => balance;
        private set
        {
            if (value > 0)
                balance = value;
        }
    }

    public BankAccount(string accNum, double initialBalance)
    {
        accountNumber = accNum;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Invalid deposit amount.");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Invalid withdraw amount.");
    }
}
