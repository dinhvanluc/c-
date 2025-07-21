// See https://aka.ms/new-console-template for more information
using T24098M.sesion2;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một tài khoản ngân hàng mới
            BankAccount account = new BankAccount("123456", "Đinh Văn Lực", 5000000);
            // In thông tin tài khoản
            account.PrintAccountInfo();
           
            account.Deposit(5000);
            // Nạp tiền vào tài khoản

            account.Withdraw(2000);
            // Rút tiền từ tài khoản

            account.PrintAccountInfo();
            // In thông tin tài khoản sau khi giao dịch
        }
    }
}