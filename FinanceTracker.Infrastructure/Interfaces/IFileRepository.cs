using System;
using System.Collections.Generic;
using System.Text;
using FinanceTracker.Domain.Entities;

namespace FinanceTracker.Infrastructure.Interfaces
{
    public interface IFileRepository
    {
        public void FileWriteRepository(List<Transaction> transactions);

        public void FileReadRepository(string pathFile, List<Transaction> transactions);
    }
}
