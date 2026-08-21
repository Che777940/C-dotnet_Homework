using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Interfaces
{
    internal interface ICurrencyConverter
    {
        Task<decimal> ConvertAsync(string currencyId, decimal amount);
    }
}
