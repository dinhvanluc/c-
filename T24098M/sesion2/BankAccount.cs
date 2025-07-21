using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.sesion2
{
    internal class BankAccount
    {
        public string AccountNumber {  get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; }

        // Constructor
        public BankAccount(string accountNumber, string ownerName, double balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        // nạp tiền 
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // rút tiền
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. New balance: {Balance}");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
        // in thông tin tài khoản
        public void PrintAccountInfo()
        {
            Console.WriteLine("\n---Thông tin tài khoản---- ");
            Console.WriteLine("So tai khoan: {123456}");
            Console.WriteLine("Chu tai khoan: {dinh văn luc}");
            Console.WriteLine("So du: {2500000}");
        }

    }
}
