using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Interfaces
{
    public interface IFinanceService
    {
        decimal GetTotalIncome();

        decimal GetTotalExpense();

        void AddTransaction();

        void GetAllTransaction();
    }
}
