using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            balance = 0m;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal canceled.");
            }
            else
            {
                balance -= amount;
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

}
