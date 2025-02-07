using System;
using System.Collections.Generic;

// Represents a bank that manages customers and accounts
class Bank
{
    public string Name { get; set; }
    private List<Customer> Customers = new List<Customer>();
    
    public Bank(string name)
    {
        Name = name;
    }
    
    // Method to open an account for a customer
    public void OpenAccount(Customer customer, string accountType, decimal initialDeposit)
    {
        BankAccount newAccount = new BankAccount(accountType, initialDeposit, this);
        customer.AddAccount(newAccount);
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
        Console.WriteLine($"Account opened for {customer.Name} at {Name} with balance {initialDeposit:C}");
    }
}

// Represents a customer who owns bank accounts
class Customer
{
    public string Name { get; set; }
    private List<BankAccount> Accounts = new List<BankAccount>();
    
    public Customer(string name)
    {
        Name = name;
    }
    
    // Adds a bank account to the customer's account list
    public void AddAccount(BankAccount account)
    {
        Accounts.Add(account);
    }
    
    // Displays all account balances
    public void ViewBalance()
    {
        Console.WriteLine($"{Name}'s Account Balances:");
        foreach (var account in Accounts)
        {
            Console.WriteLine($"- {account.AccountType}: {account.Balance:C} at {account.Bank.Name}");
        }
    }
}

// Represents a bank account owned by a customer
class BankAccount
{
    public string AccountType { get; set; }
    public decimal Balance { get; private set; }
    public Bank Bank { get; private set; }
    
    public BankAccount(string accountType, decimal initialDeposit, Bank bank)
    {
        AccountType = accountType;
        Balance = initialDeposit;
        Bank = bank;
    }

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into {AccountType} account. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
}

class Program
{
    static void Main()
    {
        Bank myBank = new Bank("National Bank");
        Customer customer1 = new Customer("Alice");
        
        myBank.OpenAccount(customer1, "Savings", 1000);
        myBank.OpenAccount(customer1, "Checking", 500);
        
        customer1.ViewBalance();
    }
}