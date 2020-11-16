using Exceptions.Enums;

namespace Exceptions
{
    public class Account
    {
        public double Value { get; set; }
        public AccountType Type { get; set; }

        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new AccountException("Withdraw amount must be greater than zero");
            }

            Value -= value;
        }

        public void Deposit(double value)
        {
            if(value <= 0)
            {
                throw new AccountException("Deposit amount must be greater than zero");
            }

            Value += value;
        }
    }
}
