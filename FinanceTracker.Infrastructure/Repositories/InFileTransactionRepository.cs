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
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            string filePath = @"D:\C#\Homework_git\C-dotnet_Homework\FinanceTracker.Infrastructure\Files\file.json";
            string json = JsonSerializer.Serialize(transactions, options);
            File.WriteAllText(filePath,json);
        }

        public void FileReadRepository(string pathFile, List<Transaction> transactions)
        {
            if (!File.Exists(pathFile))
            {
                return;
            }

            string data = File.ReadAllText(pathFile);
            List<Transaction> transaction = JsonSerializer.Deserialize<List<Transaction>>(data) ?? new List<Transaction>();
            foreach (var loaded in transaction)
            {
                bool alreadyExists = transactions.Any(t =>
                    t._amount == loaded._amount &&
                    t._type == loaded._type &&
                    t._description == loaded._description &&
                    t._category.SequenceEqual(loaded._category));

                if (!alreadyExists)
                {
                    transactions.Add(loaded);
                }
            }
        }
    }
}
