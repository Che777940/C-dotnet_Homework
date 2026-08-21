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

        void AddInFile();

        public void ReadOnFile();

        Task ConvertToUsdAsync();
        Task ConvertToEurAsync();
    }
}
