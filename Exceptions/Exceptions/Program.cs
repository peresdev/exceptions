using Exceptions.Enums;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Account acc = new Account();

            try
            {
                acc.Type = AccountType.CC;
                acc.Deposit(100);
                acc.Withdraw(20);
                acc.Deposit(-10);
                //acc.Withdraw(0);
                Console.WriteLine($"Total value: {acc.Value}");
            }
            catch (AccountException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
