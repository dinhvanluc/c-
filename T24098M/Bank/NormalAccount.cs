using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Bank
{
    public class NormalAccount : AccountBase
    {
        public NormalAccount(decimal initialAmount) : base(initialAmount) { }

        public override void CheckBalance()
        {
            Console.WriteLine($"Your balancer: {balance:n0} đ");
        }
    }
}
