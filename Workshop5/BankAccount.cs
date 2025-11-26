using System;

namespace BankApp
{
    // BankAccount class
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Constructor to set account number and initial balance
        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber;

            if (initialBalance > 0)
                balance = initialBalance;
            else
                throw new ArgumentException("Initial balance must be greater than 0.");
        }

        // Public property: AccountNumber (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property: Balance (read-only for outside)
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                    balance = value;
                else
                    throw new ArgumentException("Balance must be greater than 0.");
            }
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. Remaining balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Must be positive and less than or equal to balance.");
            }
        }
    }
}
