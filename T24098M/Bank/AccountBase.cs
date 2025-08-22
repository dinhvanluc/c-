using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Bank
{
    public abstract class AccountBase : IAccount
    {
        protected decimal balance;

        public AccountBase(decimal initialAmount)
        {
            balance = initialAmount;
        }

        public abstract void CheckBalance();

        public virtual void Transfer(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Your transferred {amount:n0} đ, Your balancer: {balance:n0} đ");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}