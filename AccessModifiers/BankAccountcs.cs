using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // Base Class: BankAccount
    public class BankAccount
    {
        // Public member: Accessible anywhere
        public string AccountNumber { get; set; }

        // Protected member: Accessible in derived classes
        protected string AccountHolder;

        // Private member: Accessible only within this class
        private double Balance;

        // Constructor to initialize account details
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Public Method to Deposit Money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: ${amount:F2}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        // Public Method to Withdraw Money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount:F2}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount!");
            }
        }

        // Public Method to Get Balance
        public double GetBalance()
        {
            return Balance;
        }

        // Public Method to Display Account Details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: ${Balance:F2}");
            Console.WriteLine();
        }
    }

    // Derived Class: SavingsAccount
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; } // In percentage

        // Constructor using base class constructor
        public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            InterestRate = interestRate;
        }

        // Method to Calculate Interest
        public double CalculateInterest()
        {
            return GetBalance() * (InterestRate / 100);
        }

        // Method to Display Savings Account Details
        public void DisplaySavingsAccountDetails()
        {
            Console.WriteLine($"Savings Account Number: {AccountNumber}"); // Accessible due to 'public' modifier
            Console.WriteLine($"Account Holder: {AccountHolder}"); // Accessible due to 'protected' modifier
            Console.WriteLine($"Balance: ${GetBalance():F2}"); // Accessing private member using public method
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Interest Earned: ${CalculateInterest():F2}");
            Console.WriteLine();
        }
    }
}
