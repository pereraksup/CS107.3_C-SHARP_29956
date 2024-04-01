using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. Updated balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive amount.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Instantiate a BankAccount object
            BankAccount myAccount = new BankAccount("123456789");

            // Perform a deposit
            Console.Write("Enter the deposit amount: ");
            decimal depositAmount;

            // Validate user input
            while (!decimal.TryParse(Console.ReadLine(), out depositAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the deposit amount: ");
            }

            // Deposit money into the account
            myAccount.Deposit(depositAmount);

            Console.ReadLine(); // To keep the console window open
        }
    }
}
