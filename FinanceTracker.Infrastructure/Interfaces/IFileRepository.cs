using System;
using System.Collections.Generic;
using System.Text;
using FinanceTracker.Domain.Entities;

namespace FinanceTracker.Infrastructure.Interfaces
{
    public interface IFileRepository
    {
        public void FileWriteRepository(Transaction transaction);

        public void FileReadRepository();
    }
}
