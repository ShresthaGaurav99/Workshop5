using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {       
            //----------------Task1------------------
            // Create BankAccount object
            BankAccount myAccount = new BankAccount("ACC12345", 5000);

            // Display account number and initial balance
            Console.WriteLine("Account Number: " + myAccount.AccountNumber);
            Console.WriteLine("Initial Balance: " + myAccount.Balance);

            // Deposit money
            myAccount.Deposit(2000);

            // Withdraw money
            myAccount.Withdraw(1500);

            // Print remaining balance
            Console.WriteLine("Final Balance: " + myAccount.Balance);
        }
    }
}
