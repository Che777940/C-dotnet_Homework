using System;
using System.Collections.Generic;
using System.Text;
using FinanceTracker.Domain.Entities;

namespace FinanceTracker.Infrastructure.Interfaces
{
    public interface IRepository
    {
        void AddInRepository(Transaction transaction);
        List<Transaction> GetAll();

        Guid GetById(Guid _id);
    }
}
