using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Task
{
    public class Debt
    {
        public double balance;
        public double InterestRate;
        public Debt(double initialBalance, double initialInterestRate)
        {
            balance = initialBalance;
            InterestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Итоговый баланс: {balance}");
        }

        public void WaitOneYear()
        {
            balance = balance * InterestRate;
        }


    }
}
