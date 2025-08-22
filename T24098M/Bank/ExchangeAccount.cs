using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Bank
{
    public class ExchangeAccount : AccountBase
    {
        private decimal exchangeRate;
        private decimal amount;

        public ExchangeAccount(decimal exchangeRate, decimal amount) : base(exchangeRate * amount)
        {
            this.exchangeRate = exchangeRate;
            this.amount = amount;
        }

        public override void CheckBalance()
        {
            Console.WriteLine($"Your balancer: {balance:n0} đ");
        }
    }
}
