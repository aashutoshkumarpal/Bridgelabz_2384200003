using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModeling
{
    public class Bank
    {
        public string BankName { get; set; }
        private List<Account> accounts;

        public Bank(string bankName)
        {
            BankName = bankName;
            accounts = new List<Account>();
        }

        public void OpenAccount(Customer customer, double initialDeposit)
        {
            Account newAccount = new Account(customer, this, initialDeposit);
            accounts.Add(newAccount);
            customer.AddAccount(newAccount);
            Console.WriteLine($"Account opened for {customer.Name} at {BankName} with initial deposit: {initialDeposit:C}");
        }

        public void DisplayAccounts()
        {
            Console.WriteLine($"\nAccounts in {BankName}");

            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts available.");
            }
            else
            {
                foreach (Account account in accounts)
                {
                    account.DisplayAccountDetails();
                }
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        private List<Account> accounts;

        public Customer(string name)
        {
            this.Name = name;
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void ViewBalance()
        {
            Console.WriteLine($"\nAccounts of {Name}:");

            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts found.");
            }
            else
            {
                foreach (var account in accounts)
                {
                    Console.WriteLine($"Bank: {account.Bank.BankName}, Balance: {account.Balance:C}");
                }
            }
        }
    }

    public class Account
    {
        public Customer AccountHolder { get; }
        public Bank Bank { get; }
        public double Balance { get; private set; }

        public Account(Customer customer, Bank bank, double initialDeposit)
        {
            AccountHolder = customer;
            Bank = bank;
            Balance = initialDeposit;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Holder: {AccountHolder.Name}, Bank: {Bank.BankName}, Balance: {Balance:C}");
        }
    }

    public class BankDemo
    {
        public void InputMethod()
        {
            // Creating banks
            Bank bank1 = new Bank("National Bank");
            Bank bank2 = new Bank("City Bank");

            // Creating customers
            Customer customer1 = new Customer("Alice");
            Customer customer2 = new Customer("Bob");

            // Opening accounts
            bank1.OpenAccount(customer1, 1000);
            bank1.OpenAccount(customer2, 2000);
            bank2.OpenAccount(customer1, 3000);

            // Displaying bank details
            bank1.DisplayAccounts();
            bank2.DisplayAccounts();

            // Viewing balances
            customer1.ViewBalance();
            customer2.ViewBalance();
        }
    }
}
