using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using FinanceTracker.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Infrastructure.Repositories
{
    public class InMemoryTransactionRepository : IRepository
    {
        private readonly List<Transaction> _transactions = new()
        {
            new Transaction
            {
                _amount = 4000,
                _type = TransactionType.Income,
                _category = {"Зарплата", "Фиксированная"},
                _description = "Аванс"
            },
            new Transaction
            {
                _amount = 200,
                _type = TransactionType.Expense,
                _category = {"Еда", "Фрукты"},
                _description = "Продукты"
            }

        };

        public void AddInRepository(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public List<Transaction> GetAll()
        {
            return _transactions;
        }

        public Guid GetById(Guid _id)
        {
            return _id;
        }
    }
}
