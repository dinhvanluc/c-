using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24098M.Bank
{
   public interface  IAccount
    {
        void CheckBalance();
        void Transfer(decimal amount);
    }
}
