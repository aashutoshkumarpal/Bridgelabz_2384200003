using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    // Abstract class BankAccount
    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        protected double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            private set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public BankAccount(string accountNumber, string holderName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public abstract double CalculateInterest();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account: {accountNumber}, Holder: {holderName}, Balance: {balance:C}");
        }
    }

    // Interface ILoanable
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    // Savings Account (Interest: 4% Annually)
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.04; // 4% interest annually
        }
    }

    // Current Account (No Interest, Loan Facility)
    class CurrentAccount : BankAccount, ILoanable
    {
        private double loanLimit;

        public CurrentAccount(string accountNumber, string holderName, double initialBalance, double loanLimit)
            : base(accountNumber, holderName, initialBalance)
        {
            this.loanLimit = loanLimit;
        }

        public override double CalculateInterest()
        {
            return 0; // No interest for current accounts
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 2 + loanLimit; // Loan eligibility is twice the balance plus loan limit
        }

        public void ApplyForLoan(double amount)
        {
            if (amount <= CalculateLoanEligibility())
            {
                Console.WriteLine($"Loan of {amount:C} approved.");
            }
            else
            {
                Console.WriteLine($"Loan amount exceeds eligibility of {CalculateLoanEligibility():C}.");
            }
        }
    }
}
