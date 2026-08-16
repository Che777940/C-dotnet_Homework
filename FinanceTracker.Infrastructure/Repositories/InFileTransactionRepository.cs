using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using FinanceTracker.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace FinanceTracker.Infrastructure.Repositories
{
    public class InFileTransactionRepository : IFileRepository
    {
        public void FileWriteRepository(List<Transaction> transactions)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            string filePath = @"D:\C#\Homework_git\C-dotnet_Homework\FinanceTracker.Infrastructure\Files\file.json";
            string json = JsonSerializer.Serialize(transactions, options);
            File.WriteAllText(filePath,json);
        }

        public void FileReadRepository(string pathFile, List<Transaction> transactions)
        {
            string data = File.ReadAllText(pathFile);
            List<Transaction> transaction = JsonSerializer.Deserialize<List<Transaction>>(data);
            transactions.AddRange(transaction);
        }
    }
}
