using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Program
    {
        static void ProcessAccounts(List<BankAccount> accounts)
        {
            foreach (var account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine($"Interest Earned: {account.CalculateInterest():C}");

                if (account is ILoanable loanableAccount)
                {
                    Console.WriteLine($"Loan Eligibility: {loanableAccount.CalculateLoanEligibility():C}");
                    loanableAccount.ApplyForLoan(5000); // Example loan application
                }

                Console.WriteLine();
            }
        }


        static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("SA123", "John Doe", 10000),
            new CurrentAccount("CA456", "Jane Smith", 20000, 5000)
        };

            ProcessAccounts(accounts);
        }
    }
}
