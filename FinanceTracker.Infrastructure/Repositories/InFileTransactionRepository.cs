using FinanceTracker.Infrastructure.Interfaces;
using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace FinanceTracker.Infrastructure.Repositories
{
    public class InFileTransactionRepository : IFileRepository
    {
        public void FileWriteRepository(Transaction transaction)
        {
            //string json = JsonSerializer.Serialize(transaction);
            //File.WriteAllText("data.json", json);
            //string text = File.ReadAllText("data.json");

            using (var fs = File.Create("data.json"))
            {
                JsonSerializer.Serialize(fs, transaction);
            }
            bool created = File.Exists;
            Console.WriteLine($"Файл создан: {created}");
        }

        public void FileReadRepository()
        {

        }
    }
}
