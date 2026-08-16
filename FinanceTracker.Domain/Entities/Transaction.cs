using FinanceTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FinanceTracker.Domain.Entities
{
    public class Transaction
    {
        [JsonIgnore]
        public Guid _id { get; set; } = Guid.NewGuid();
        public decimal _amount { get;  set; }
        public TransactionType _type { get; set; }
        public List<string> _category { get; set; } = new List<string>();
        public string _description { get; set; } = string.Empty;
        public DateTime _date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"Сумма: {_amount}\nТип: {(_type == TransactionType.Income ? "Доход" : "Расход")}\nКатегории: {string.Join(", ", _category)}\nОписание: {_description}";
        }
    }
}
