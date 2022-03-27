using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class ATMService : IATMService
    {
        public Customer customer;
        public ATMService(Customer customer)
        {
            this.customer = customer;
        }

        public void BalanceInquiry()
        {
            Console.WriteLine("-----Balance Inquiry-----");
            Console.WriteLine();
            Console.WriteLine($"Name: \t\t\t:{customer.FirstName} {customer.LastName}");
            Console.WriteLine($"UserID: \t\t:{customer.UserID}");
            Console.WriteLine($"Current Balance: \t:${customer.currentBalance}");
            Console.WriteLine($"Pincode: \t\t:{customer.PinCode}");
            Console.WriteLine($"Address: \t\t:{customer.Address}");
            Console.WriteLine();

            StandardMessages.ProceedToMenu();
        }

        public void Deposit()
        {
            Console.WriteLine("-----Deposit-----");
            Console.WriteLine();
            Console.WriteLine($"Customer Name: \t\t{customer.FirstName} {customer.LastName}");
            Console.WriteLine($"Current Balance: \t\t{customer.currentBalance}");
            Console.WriteLine();
            Console.Write("Enter amount of deposit: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Total Balance: \t\t\t{customer.currentBalance}");
            Console.WriteLine($"Withdrawal Amount: \t\t{amount}");

            double currentBalance = customer.currentBalance + amount;

            Console.WriteLine($"Current Balance: \t\t{currentBalance}");
            customer.currentBalance = currentBalance;

            StandardMessages.ProceedToMenu();
        }
        
        public void MoneyTransfer()
        {
            
        }

        public void Withdraw()
        {
            Console.WriteLine("-----Withdrawal-----");
            Console.WriteLine();
            Console.WriteLine($"Customer Name: \t\t{customer.FirstName} {customer.LastName}");
            Console.WriteLine($"Current Balance: \t\t{customer.currentBalance}");
            Console.WriteLine();
            Console.Write("Enter amount of withdrawal: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Total Balance: \t\t\t{customer.currentBalance}");
            Console.WriteLine($"Withdrawal Amount: \t\t{amount}");

            double currentBalance = customer.currentBalance - amount;

            Console.WriteLine($"Current Balance: \t\t{currentBalance}");
            customer.currentBalance = currentBalance;

            StandardMessages.ProceedToMenu();
        }
    }
}
