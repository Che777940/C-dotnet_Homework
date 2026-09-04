using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Domain.Exceptions
{
    public class ExpensException : Exception
    {
        public decimal Balance {  get; }
        public decimal Expence {  get; }
        public ExpensException() : base() {}

        public ExpensException(decimal balance, decimal expence) : base($"Баланс отрицательный {balance}, расход в сумму {expence} не допустим")
        {
            Balance = balance;
            Expence = expence;
        }


    }
}
