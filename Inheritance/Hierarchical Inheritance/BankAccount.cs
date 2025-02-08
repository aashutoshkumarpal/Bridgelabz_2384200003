using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Hierarchical_Inheritance
{
    // Base class
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("General Bank Account");
        }
    }

    // Subclass SavingsAccount
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account with Interest Rate: " + InterestRate + "%");
        }
    }

    // Subclass CheckingAccount
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account with Withdrawal Limit: $" + WithdrawalLimit);
        }
    }

    // Subclass FixedDepositAccount
    class FixedDepositAccount : BankAccount
    {
        public int DepositTerm { get; set; } // Term in months

        public FixedDepositAccount(int accountNumber, double balance, int depositTerm)
            : base(accountNumber, balance)
        {
            DepositTerm = depositTerm;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account with Term: " + DepositTerm + " months");
        }
    }
}
