using FinanceTracker.Application.Interfaces;
using FinanceTracker.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace FinanceTracker.Application.Services
{
    public class CurrencyConversion : ICurrencyConverter
    {
        private readonly string uri = "https://api.nbrb.by/exrates/rates/";
        public async Task<decimal> ConvertAsync(string currencyId, decimal amount)
        { 

            HttpClient client = new HttpClient();
            var response = await client.GetFromJsonAsync<NbrbCurrencyResponse>($"{uri}{currencyId}");


            if (response == null)
            {
                throw new InvalidOperationException($"Не удалось получить курс валют. ");
            }

            return amount * response.Cur_Scale / response.Cur_OfficialRate;
        }
    }
}
