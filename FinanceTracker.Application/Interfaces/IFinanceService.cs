using System;
using System.Collections.Generic;
using System.Text;
using FinanceTracker.Domain.Entities;

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

        public List<Transaction> GetAllTransactionWeb();

        public void AddTransactionWeb(Transaction transaction);

        public void DeleteTransaction(Guid id);

        public void EditTransaction(Transaction transaction);

    }
}
